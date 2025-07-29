using System.ComponentModel.DataAnnotations;

namespace RegisterAPII.DTOs
{
    public class UpdateReportStatusDto
    {
        [Required]
        // You can add validation to ensure this is only "Accepted" or "Declined"
        public string Status { get; set; }
    }
}
