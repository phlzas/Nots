namespace RegisterAPII.Models
{
    public class AbsenceRecord
    {

        public int Id { get; set; } // Database-generated primary key
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime Date { get; set; }
        public int Session { get; set; }
        public string ClassId { get; set; }
    }
}
