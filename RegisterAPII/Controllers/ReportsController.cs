using Microsoft.AspNetCore.Mvc;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using System;

namespace RegisterAPII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly IReportRepository _repository;

        public ReportsController(IReportRepository repository)
        {
            _repository = repository;
        }

        // GET /api/reports
        [HttpGet]
        public async Task<IActionResult> GetReports()
        {
            var reports = await _repository.GetAllReportsAsync();
            return Ok(reports);
        }

        // POST /api/reports
        [HttpPost]
        public async Task<IActionResult> SubmitReport([FromBody] CreateReportDto reportDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var report = new Report
            {
                StudentName = reportDto.StudentName,
                Description = reportDto.Description,
                SpecialistSignature = reportDto.SpecialistSignature,
                // Date and "Pending" status are set by the model's constructor
            };

            var createdReport = await _repository.CreateReportAsync(report);

            // Return a 201 Created status with the new report object
            return CreatedAtAction(nameof(GetReports), new { id = createdReport.Id }, createdReport);
        }

        // PUT /api/reports/{id}/status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateReportStatus(int id, [FromBody] UpdateReportStatusDto statusDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Validate the status to prevent incorrect values
            if (statusDto.Status != "Accepted" && statusDto.Status != "Declined")
            {
                return BadRequest("Status must be 'Accepted' or 'Declined'.");
            }

            var success = await _repository.UpdateReportStatusAsync(id, statusDto.Status);

            if (!success)
            {
                return NotFound("Report not found.");
            }

            return NoContent(); // Success
        }
    }
}
