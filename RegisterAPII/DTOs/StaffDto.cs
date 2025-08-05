using System.ComponentModel.DataAnnotations;

namespace RegisterAPII.DTOs
{
    public class StaffDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public DateTime? CheckInTime { get; set; }
        public string CheckInMethod { get; set; }
        public DateTime Date { get; set; }
        public int? AccountId { get; set; }
        public int? RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreateStaffAttendanceDto
    {
        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Status { get; set; } // "Present", "Late", "Absent"

        public DateTime? CheckInTime { get; set; }

        [Required]
        public string CheckInMethod { get; set; } // "Fingerprint", "FaceID", "Manual"

        public int? AccountId { get; set; }
        public int? RoleId { get; set; }
    }

    public class UpdateStaffAttendanceDto
    {
        [Required]
        public string Status { get; set; }
        
        public DateTime? CheckInTime { get; set; }
        
        [Required]
        public string CheckInMethod { get; set; }
    }
}