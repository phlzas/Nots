namespace RegisterAPII.DTOs
{
    public class StudentAttendanceDto
    {
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }
        public List<BehaviorNoteDto> Notes { get; set; }
        public int NoteId { get; set; }
    }
}
