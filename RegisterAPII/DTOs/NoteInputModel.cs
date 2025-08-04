namespace RegisterAPII.DTOs
{
    public class NoteInputModel
    {
        public int StudentId { get; set; }
        public int SessionNumber { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string NoteType { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string gen { get; set; }
        
    }
}
