using Microsoft.AspNetCore.Mvc;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;

namespace RegisterAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbsenceController : ControllerBase
    {
        private readonly IAbsenceRepository _repo;
        public AbsenceController(IAbsenceRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var absences = await _repo.GetAllAsync();
            return Ok(absences);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var absence = await _repo.GetByIdAsync(id);
            if (absence == null) return NotFound();
            return Ok(absence);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAbsenceRecordDto dto)
        {
            await _repo.AddAsync(dto);
            return Ok(new { message = "Absence record added." });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.DeleteAsync(id);
            return Ok(new { message = "Absence record deleted." });
        }

        [HttpGet("filtered")]
        public async Task<IActionResult> GetFiltered([FromQuery] string? grade = null, [FromQuery] string? className = null, [FromQuery] int? session = null, [FromQuery] string? date = null)
        {
            DateTime? parsedDate = null;
            if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out var tempDate))
            {
                parsedDate = tempDate;
            }

            var absences = await _repo.GetFilteredAbsencesAsync(grade, className, session, parsedDate);
            return Ok(absences);
        }

        [HttpGet("grades-classes")]
        public async Task<IActionResult> GetGradesAndClasses()
        {
            var gradesAndClasses = await _repo.GetGradesAndClassesAsync();
            return Ok(gradesAndClasses);
        }
    }
}
