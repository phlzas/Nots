using Microsoft.AspNetCore.Mvc;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;

namespace RegisterAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository _repo;
        private readonly ILogger<StaffController> _logger;

        public StaffController(IStaffRepository repo, ILogger<StaffController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpPost("checkin")]
        public async Task<IActionResult> CheckInStaff([FromBody] CreateStaffAttendanceDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var createdStaff = await _repo.CreateStaffAttendanceAsync(dto);
                _logger.LogInformation("Staff check-in recorded for {EmployeeName}", dto.EmployeeName);
                
                return CreatedAtAction(nameof(GetStaffAttendanceById), 
                    new { id = createdStaff.Id }, createdStaff);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error recording staff check-in for {EmployeeName}", dto.EmployeeName);
                return StatusCode(500, new { message = "An error occurred while recording check-in." });
            }
        }

        [HttpGet("attendance/{date}")]
        public async Task<IActionResult> GetStaffAttendanceByDate(DateTime date)
        {
            try
            {
                var staffAttendance = await _repo.GetStaffAttendanceByDateAsync(date);
                return Ok(staffAttendance);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving staff attendance for date {Date}", date);
                return StatusCode(500, new { message = "An error occurred while retrieving attendance." });
            }
        }

        [HttpGet("department/{department}")]
        public async Task<IActionResult> GetStaffByDepartment(string department, [FromQuery] DateTime? date = null)
        {
            try
            {
                var staffAttendance = await _repo.GetStaffAttendanceByDepartmentAsync(department, date);
                return Ok(staffAttendance);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving staff attendance for department {Department}", department);
                return StatusCode(500, new { message = "An error occurred while retrieving department attendance." });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaffAttendanceById(int id)
        {
            try
            {
                var staff = await _repo.GetStaffAttendanceByIdAsync(id);
                if (staff == null)
                {
                    return NotFound(new { message = "Staff attendance record not found." });
                }

                return Ok(staff);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving staff attendance for ID {Id}", id);
                return StatusCode(500, new { message = "An error occurred while retrieving attendance record." });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStaffAttendance(int id, [FromBody] UpdateStaffAttendanceDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var success = await _repo.UpdateStaffAttendanceAsync(id, dto);
                if (!success)
                {
                    return NotFound(new { message = "Staff attendance record not found." });
                }

                _logger.LogInformation("Staff attendance updated successfully for ID {Id}", id);
                return Ok(new { message = "Staff attendance updated successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating staff attendance for ID {Id}", id);
                return StatusCode(500, new { message = "An error occurred while updating attendance." });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaffAttendance(int id)
        {
            try
            {
                var success = await _repo.DeleteStaffAttendanceAsync(id);
                if (!success)
                {
                    return NotFound(new { message = "Staff attendance record not found." });
                }

                _logger.LogInformation("Staff attendance deleted successfully for ID {Id}", id);
                return Ok(new { message = "Staff attendance deleted successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting staff attendance for ID {Id}", id);
                return StatusCode(500, new { message = "An error occurred while deleting attendance." });
            }
        }

        [HttpGet("history/{accountId}")]
        public async Task<IActionResult> GetStaffAttendanceHistory(int accountId, 
            [FromQuery] DateTime? fromDate, [FromQuery] DateTime? toDate)
        {
            try
            {
                var history = await _repo.GetStaffAttendanceHistoryAsync(accountId, fromDate, toDate);
                return Ok(history);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving staff attendance history for Account ID {AccountId}", accountId);
                return StatusCode(500, new { message = "An error occurred while retrieving attendance history." });
            }
        }

        [HttpGet("daily-report")]
        public async Task<IActionResult> GetDailyStaffReport([FromQuery] DateTime date)
        {
            try
            {
                var staffAttendance = await _repo.GetStaffAttendanceByDateAsync(date);
                
                var report = new
                {
                    Date = date.Date,
                    TotalStaff = staffAttendance.Count(),
                    Present = staffAttendance.Count(s => s.Status == "Present"),
                    Late = staffAttendance.Count(s => s.Status == "Late"),
                    Absent = staffAttendance.Count(s => s.Status == "Absent"),
                    AttendanceDetails = staffAttendance
                };

                return Ok(report);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating daily staff report for date {Date}", date);
                return StatusCode(500, new { message = "An error occurred while generating the report." });
            }
        }
    }
}