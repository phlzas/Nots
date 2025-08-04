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
    }
}
