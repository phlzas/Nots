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
        // This holds the secret key string from your configuration.
        private readonly string _key;

        // The key is injected here when JwtService is created.
        // The comment "تم تمرير المفتاح من الـ Configuration أو مباشرة من الـ Startup"
        // confirms it comes from your configuration (e.g., appsettings.json).
        public JwtService(string key)
        {
            _key = key;
        }

        // This is your primary method for creating the JWT.
        public string GenerateToken(Accounts user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            // --- CRITICAL POINT #1: KEY ENCODING ---
            // You are converting your secret string into a byte array using ASCII.
            // This is a very common source of errors.
            var key = Encoding.ASCII.GetBytes(_key);

            // These are the claims (the token's payload).
            // This section looks good and defines the user's identity.
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()), // Standard claim for User ID
                new Claim("fullName", user.FullName), // Custom claim for the user's full name
                new Claim(ClaimTypes.Email, user.Email), // Standard claim for Email
                new Claim(ClaimTypes.Role, user.Role.Name) // Standard claim for Role
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),

                // --- CRITICAL POINT #2: SIGNING CREDENTIALS ---
                // The token is signed here using the HMAC-SHA256 algorithm.
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}