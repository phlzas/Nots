namespace RegisterAPII.Interfaces
{
    public interface IReportRepository
    {
        Task<IEnumerable<Report>> GetAllReportsAsync();
        Task<Report> CreateReportAsync(Report report);
        Task<bool> UpdateReportStatusAsync(int reportId, string newStatus);
    }
}
