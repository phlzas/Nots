using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.DTOs;      // Your Data Transfer Objects
using RegisterAPII.Interfaces; // Your IAuthService interface
using RegisterAPII.Models;
using System.Threading.Tasks;

namespace RegisterAPII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        // The service is correctly injected here using Dependency Injection
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("check")]
        public async Task<IActionResult> CheckUser([FromBody] CheckuserDTO dto)
        {
            if (string.IsNullOrEmpty(dto.FullName) || string.IsNullOrEmpty(dto.NationalID))
                return BadRequest("الاسم أو الرقم القومي غير موجود.");

            var result = await _authService.CheckUserAsync(dto.FullName, dto.NationalID);
            return Ok(result);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var result = await _authService.LoginAsync(dto);

            if (result == "Email not registered." || result == "Incorrect password.")
                return Unauthorized(new { message = result });

            return Ok(new { token = result });
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup(SignupDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.SignupAsync(dto);

            if (result == "Email already registered.")
                return BadRequest(new { message = result });
            
            if (result == "Invalid role selected.")
                return BadRequest(new { message = result });

            if (result == "Registration successful.")
                return Ok(new { message = result });

            return StatusCode(500, new { message = "Registration failed." });
        }

        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _authService.GetRolesAsync();
            return Ok(roles);
        }
    }
}