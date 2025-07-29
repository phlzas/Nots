using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;

namespace RegisterAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceRepository _repo;
        public AttendanceController(IAttendanceRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("save")]
        public async Task<IActionResult> SaveAttendance([FromBody] SaveAttendanceDto dto)
        {
            await _repo.SaveAttendanceAsync(dto);
            return Ok(new { message = "Attendance saved successfully." });
        }

        [HttpPost("add-note")]
        public async Task<IActionResult> AddNote([FromBody] NoteInputModel model)
        {
            await _repo.AddNoteAsync(model);
            return Ok(new { message = "Note added successfully." });
        }
    }
}
