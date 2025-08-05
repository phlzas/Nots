using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterAPII.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string EmployeeName { get; set; }

        [Required, MaxLength(50)]
        public string Department { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; } // "Present", "Late", "Absent"

        public DateTime? CheckInTime { get; set; }

        [Required, MaxLength(20)]
        public string CheckInMethod { get; set; } // "Fingerprint", "FaceID", "Manual"

        public DateTime Date { get; set; } = DateTime.UtcNow.Date;

        // Foreign key relationships based on existing models
        public int? AccountId { get; set; }
        public Accounts Account { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}