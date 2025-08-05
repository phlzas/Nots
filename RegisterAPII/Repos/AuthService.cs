// --- File: Repos/AuthService.cs ---

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RegisterAPII.Repos
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;
        private readonly EmailService _emailService;
        private readonly ApplicationDbContext _context;

        public AuthService(IUserRepository userRepository, IJwtService jwtService, EmailService emailService , ApplicationDbContext dbContext)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
            _emailService = emailService;
            _context = dbContext;
        }


        public async Task<object> CheckUserAsync(string fullName, string nationalId)
        {
            var login = await _context.LoginAccounts
                .Include(l => l.Accounts)
                .FirstOrDefaultAsync(l => l.NationalID == nationalId && l.Accounts.FullName == fullName);

            if (login != null)
            {
                return new
                {
                    Status = "LoginAccountExists",
                    FullName = login.Accounts.FullName,
                    Email = login.Email,
                    Password = login.Password
                };
            }
            var account = await _context.Accounts
                .FirstOrDefaultAsync(a => a.NationalID == nationalId && a.FullName == fullName);

            if (account != null)
            {
                var loginExists = await _context.LoginAccounts.AnyAsync(l => l.AccountId == account.Id);

                if (!loginExists)
                {
                    var generatedEmail = GenerateEmail(account.FullName, account.NationalID);

                    if (string.IsNullOrEmpty(account.Email))
                    {
                        account.Email = generatedEmail;
                        await _context.SaveChangesAsync();
                    }

                    return new
                    {
                        Status = "AccountExistsNoLogin",
                        Email = account.Email
                    };
                }

                return new
                {
                    Status = "AccountExists",
                    Email = account.Email
                };
            }

            return new
            {
                Status = "NotFound"
            };
        }

        public async Task<string?> LoginAsync(LoginDto dto)
        {
            var user = await _context.Accounts
                .Include(a => a.Role) // This tells EF Core to join the Roles table
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (user == null)
                return "Email not registered.";

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password);
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(dto.Password, hashedPassword);


            if (!isPasswordValid)
                return "Incorrect password.";

            // Generate JWT Token
            var token = _jwtService.GenerateToken(user);
            return token;
        }



        private string GenerateEmail(string fullName, string nationalId)
        {
            var names = fullName.Trim().ToLower().Split(' ');

            var first = names.Length > 0 ? names[0] : "user";
            var second = names.Length > 1 ? names[1] : "name";

            var last6 = nationalId.Length >= 6 ? nationalId.Substring(nationalId.Length - 6) : "000000";

            return $"{first}.{second}.{last6}@gmail.com";
        }


    // --- END: FULLY CORRECTED LOGIN METHOD ---

    public async Task<string?> ForgotPasswordAsync(ForgotPasswordDto dto)
        {
            var user = await _userRepository.GetUserByEmailAsync(dto.Email.ToLower());
            if (user == null) return "Email not registered.";
            var token = Guid.NewGuid().ToString();
            user.ResetToken = token;
            user.ResetTokenExpiry = DateTime.UtcNow.AddHours(1);
            await _userRepository.SaveChangesAsync();
            await _emailService.SendEmailAsync(dto.Email, "Reset Password", $"Your token is: {token}");
            return "Token sent to your email.";
        }

        public async Task<string?> ResetPasswordAsync(string token, ResetPasswordDto dto)
        {
            var user = await _userRepository.GetUserByResetTokenAsync(token);
            if (user == null) return "Invalid or expired token.";
            if (dto.NewPassword != dto.ConfirmPassword) return "Passwords do not match.";
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);
            user.ResetToken = null;
            user.ResetTokenExpiry = null;
            await _userRepository.SaveChangesAsync();
            return "Password changed successfully.";
        }

        public async Task<string?> SignupAsync(SignupDto dto)
        {
            // Check if email already exists
            var existingUser = await _context.Accounts
                .FirstOrDefaultAsync(u => u.Email == dto.Email);
            
            if (existingUser != null)
                return "Email already registered.";

            // Check if role exists
            var role = await _context.Roles.FindAsync(dto.RoleId);
            if (role == null)
                return "Invalid role selected.";

            // Generate a unique national ID (you might want to make this required from frontend)
            var nationalId = GenerateUniqueNationalId();

            // Create new account
            var newAccount = new Accounts
            {
                FullName = dto.FullName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                NationalID = nationalId,
                RoleId = dto.RoleId,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };

            // Create corresponding login account
            var newLoginAccount = new LoginAccount
            {
                Email = dto.Email,
                Password = dto.Password, // Store plain password as per your existing structure
                NationalID = nationalId
            };

            _context.Accounts.Add(newAccount);
            _context.LoginAccounts.Add(newLoginAccount);
            
            await _context.SaveChangesAsync();

            // Link the accounts
            newLoginAccount.AccountId = newAccount.Id;
            newAccount.LoginId = newLoginAccount.Id;
            
            await _context.SaveChangesAsync();

            return "Registration successful.";
        }

        public async Task<List<Role>> GetRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        private string GenerateUniqueNationalId()
        {
            // Generate a unique 14-digit national ID
            var random = new Random();
            string nationalId;
            bool exists;
            
            do
            {
                nationalId = "30101010" + random.Next(100000, 999999).ToString();
                exists = _context.Accounts.Any(a => a.NationalID == nationalId);
            } while (exists);
            
            return nationalId;
        }
    }
}