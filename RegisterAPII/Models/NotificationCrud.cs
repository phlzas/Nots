using System;

namespace RegisterAPII.Models
{
    public class NotificationCrud
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descreption { get; set; }
        public string Role { get; set; }
        public DateTime Date { get; set; }
        public bool IsRidden { get; set; }
    }
}