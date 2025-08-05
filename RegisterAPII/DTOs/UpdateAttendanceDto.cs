using System.ComponentModel.DataAnnotations;

namespace RegisterAPII.DTOs
{
    public class UpdateAttendanceDto
    {
        [Required]
        public bool IsPresent { get; set; }
        
        public string Note { get; set; }
        
        public DateTime Date { get; set; }
        
        public int SessionNumber { get; set; }
    }
}