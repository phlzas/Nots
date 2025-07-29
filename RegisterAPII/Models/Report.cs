using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Report
{
    [Key] // Marks this as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tells the DB to auto-generate the ID
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string StudentName { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string SpecialistSignature { get; set; } // The name of the person who submitted it

    [Required]
    public string Status { get; set; } // "Pending", "Accepted", "Declined"

    // A constructor can be helpful to set default values
    public Report()
    {
        Date = DateTime.UtcNow;
        Status = "Pending";
    }
}