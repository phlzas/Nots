using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.Interfaces;

namespace RegisterAPII.Repos
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;

        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Report>> GetAllReportsAsync()
        {
            return await _context.Reports.OrderByDescending(r => r.Date).ToListAsync();
        }

        public async Task<Report> CreateReportAsync(Report report)
        {
            await _context.Reports.AddAsync(report);
            await _context.SaveChangesAsync();
            return report;
        }

        public async Task<bool> UpdateReportStatusAsync(int reportId, string newStatus)
        {
            var reportToUpdate = await _context.Reports.FindAsync(reportId);

            if (reportToUpdate == null)
            {
                return false; // Not found
            }

            reportToUpdate.Status = newStatus;
            await _context.SaveChangesAsync();

            // TODO: If newStatus is "Accepted", this is where you would add logic
            // to trigger an email or notification to the parent.

            return true; // Success
        }
    }
}
