namespace RegisterAPII.Models
{
    public class AttendanceRecord
    {
            public int Id { get; set; }
            public int StudentId { get; set; }
            public DateTime Date { get; set; }
            public int SessionNumber { get; set; }
            public bool IsPresent { get; set; }
        public int? NoteId { get; set; }   
        public Note Note { get; set; }
    }
}
