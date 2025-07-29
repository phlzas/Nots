using System.ComponentModel.DataAnnotations;

namespace RegisterAPII.DTOs
{
    public class CreateReportDto
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string SpecialistSignature { get; set; }
    }
}
