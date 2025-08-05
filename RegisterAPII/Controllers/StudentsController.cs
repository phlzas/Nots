// Controllers/StudentsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.Models;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StudentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/students/Junior%201
    [HttpGet("{classId}")]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudentsByClass(int classId)
    {
        if (classId == null)
        {
            return BadRequest("A class ID must be provided.");
        }

        var students = await _context.Students
                                     .Where(s => s.ClassId == classId)
                                     .ToListAsync();

        if (students == null || !students.Any())
        {
            return NotFound("No students found for this class.");
        }

        return Ok(students);
    }
}