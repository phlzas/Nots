namespace RegisterAPII.DTOs
{
    public class CreateAbsenceRecordDto
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime Date { get; set; }
        public int Session { get; set; }
        public string ClassId { get; set; }
    }
}