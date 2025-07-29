namespace RegisterAPII.DTOs
{
    public class SaveAttendanceDto
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public int SessionNumber { get; set; }
        public bool IsPresent { get; set; }
        public int NoteId { get; set; }
        //public List<StudentAttendanceDto> Students { get; set; }
    }
}
