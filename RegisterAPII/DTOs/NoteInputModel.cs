using System.ComponentModel.DataAnnotations;

namespace RegisterAPII.DTOs
{
    public class NoteInputModel
    {
        [Required]
        public int StudentId { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public string NoteType { get; set; } = "general";
        
        public string ImageUrl { get; set; } = "";
        
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
