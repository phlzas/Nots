// --- File: Repos/JwtService.cs ---

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RegisterAPII.Repos
{
    public class JwtService : IJwtService
    {
        private readonly string _key;

        // تم تمرير المفتاح من الـ Configuration أو مباشرة من الـ Startup
        public JwtService(string key)
        {
            _key = key;
        }

        //public string GenerateToken(Accounts user)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_key);

        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.Name, user.Id.ToString()),
        //        new Claim(ClaimTypes.Email, user.Email),
        //        new Claim(ClaimTypes.Role, user.Role?.Name ?? "User") // معالجة الـ null
        //    };

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(claims),
        //        Expires = DateTime.UtcNow.AddDays(7),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}


        // --- File: Repos/JwtService.cs ---

        // ... (your existing using statements)

        public string GenerateToken(Accounts user) // Assuming 'Accounts' is your user model
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_key);

            // --- THIS IS THE CORRECTED CLAIMS LIST ---
            var claims = new[]
            {
        // Use JwtRegisteredClaimNames.NameId to produce the "nameid" claim
        new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),

        // Use a custom string "fullName" to match what React wants
        // You must ensure your 'Accounts' model has a 'FullName' property!
        new Claim("fullName", user.FullName), 
        
        // This was already correct
        new Claim(ClaimTypes.Email, user.Email),
        
        // This was already correct
        // Note: Make sure your 'Accounts' model has a 'Role' property that has a 'Name' property, or just user.Role if it's a string.
        new Claim(ClaimTypes.Role, user.Role?.Name ?? "User")
    };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7), // Or from configuration
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
