// In Controllers/StudentProfileController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;

[Route("api/[controller]")] // This means the base URL is "/api/StudentProfile"
[ApiController]
public class StudentProfileController : ControllerBase
{
    private readonly IStudentProfileRepository _repository;

    public StudentProfileController(IStudentProfileRepository repository)
    {
        _repository = repository;
    }


    // This will handle requests to: GET /api/StudentProfile
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentProfileDto>>> GetAllProfiles()
    {
        var profiles = await _repository.GetAllAsync();
        return Ok(profiles); // Returns HTTP 200 OK with the list of students
    }


    // GET /api/StudentProfile/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<StudentProfileDto>> GetProfile(int id)
    {
        var profile = await _repository.GetByIdAsync(id);
        if (profile == null)
        {
            return NotFound(); // Returns HTTP 404
        }
        return Ok(profile); // Returns HTTP 200
    }

    // PUT /api/StudentProfile/{id}
    // This is the correct endpoint for updating a profile. It matches your React code.
    [HttpPut("{id}")]
    public async Task<ActionResult<StudentProfileDto>> UpdateProfile(int id, [FromBody] StudentProfileDto dto)
    {
        if (id != dto.Id)
        {
            return BadRequest("Route ID and body ID do not match."); // Returns HTTP 400
        }

        var updatedProfile = await _repository.UpdateAsync(id, dto);
        if (updatedProfile == null)
        {
            return NotFound(); // Returns HTTP 404 if the user doesn't exist
        }

        return Ok(updatedProfile); // Returns HTTP 200 with the updated data
    }

    // DELETE /api/StudentProfile/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProfile(int id)
    {
        var success = await _repository.DeleteAsync(id);
        if (!success)
        {
            return NotFound(); // Returns HTTP 404
        }
        return NoContent(); // Returns HTTP 204 (Success, no content to return)
    }

    // POST /api/StudentProfile
    [HttpPost]
    public async Task<IActionResult> CreateProfile([FromBody] StudentProfileDto dto)
    {
        var createdProfile = await _repository.CreateAsync(dto);
        // Returns HTTP 201 and a link to the new resource, which is a REST best practice.
        return CreatedAtAction(nameof(GetProfile), new { id = createdProfile.Id }, createdProfile);
    }

    // PUT /api/StudentProfile/{id}/notes
    [HttpPut("{id}/notes")]
    public async Task<IActionResult> UpdateNotes(int id, [FromBody] NotesUpdateDto dto)
    {
        var success = await _repository.UpdateNotesAsync(id, dto);
        if (!success)
        {
            return NotFound();
        }
        return NoContent();
    }
}