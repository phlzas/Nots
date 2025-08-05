using System.ComponentModel.DataAnnotations;

namespace RegisterAPII.DTOs
{
    public class SignupDto
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }
    }
}