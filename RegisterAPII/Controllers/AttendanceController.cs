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
        private readonly ILogger<AttendanceController> _logger;

        public AttendanceController(IAttendanceRepository repo, ILogger<AttendanceController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpPost("save")]
        public async Task<IActionResult> SaveAttendance([FromBody] SaveAttendanceDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _repo.SaveAttendanceAsync(dto);
                _logger.LogInformation("Attendance saved successfully for {StudentId}", dto.StudentId);

                return Ok(new { message = "Attendance saved successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving attendance for {StudentId}", dto?.StudentId);
                return StatusCode(500, new { message = "An error occurred while saving attendance." });
            }
        }

        [HttpPost("add-note")]
        public async Task<IActionResult> AddNote([FromBody] NoteInputModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _repo.AddNoteAsync(model);
                _logger.LogInformation("Note added successfully for {StudentId}", model.StudentId);

                return Ok(new { message = "Note added successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding note for {StudentId}", model?.StudentId);
                return StatusCode(500, new { message = "An error occurred while adding the note." });
            }
        }

        [HttpGet("{studentId}/history")]
        public async Task<IActionResult> GetAttendanceHistory(int studentId, [FromQuery] DateTime? fromDate, [FromQuery] DateTime? toDate)
        {
            try
            {
                var history = await _repo.GetAttendanceHistoryAsync(studentId, fromDate, toDate);
                return Ok(history);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving attendance history for student {StudentId}", studentId);
                return StatusCode(500, new { message = "An error occurred while retrieving attendance history." });
            }
        }

        [HttpGet("daily-report")]
        public async Task<IActionResult> GetDailyAttendanceReport([FromQuery] DateTime date)
        {
            try
            {
                var report = await _repo.GetDailyAttendanceReportAsync(date);
                return Ok(report);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating daily attendance report for {Date}", date);
                return StatusCode(500, new { message = "An error occurred while generating the report." });
            }
        }

        [HttpPut("{attendanceId}")]
        public async Task<IActionResult> UpdateAttendance(int attendanceId, [FromBody] UpdateAttendanceDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var success = await _repo.UpdateAttendanceAsync(attendanceId, dto);
                if (!success)
                {
                    return NotFound(new { message = "Attendance record not found." });
                }

                _logger.LogInformation("Attendance updated successfully for ID {AttendanceId}", attendanceId);
                return Ok(new { message = "Attendance updated successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating attendance for ID {AttendanceId}", attendanceId);
                return StatusCode(500, new { message = "An error occurred while updating attendance." });
            }
        }

        [HttpDelete("{attendanceId}")]
        public async Task<IActionResult> DeleteAttendance(int attendanceId)
        {
            try
            {
                var success = await _repo.DeleteAttendanceAsync(attendanceId);
                if (!success)
                {
                    return NotFound(new { message = "Attendance record not found." });
                }

                _logger.LogInformation("Attendance deleted successfully for ID {AttendanceId}", attendanceId);
                return Ok(new { message = "Attendance deleted successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting attendance for ID {AttendanceId}", attendanceId);
                return StatusCode(500, new { message = "An error occurred while deleting attendance." });
            }
        }
    }
}
