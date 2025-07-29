namespace RegisterAPII.Models
{
    public class BehaviorNote
    {
        public int Id { get; set; }
        public int AttendanceRecordId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string NoteType { get; set; } // "Good" or "Bad"
    }
}
