using RegisterAPII.DTOs;

namespace RegisterAPII.Interfaces
{
    public interface IAttendanceRepository
    {
        Task SaveAttendanceAsync(SaveAttendanceDto dto);
        Task AddNoteAsync(NoteInputModel model);
        Task<IEnumerable<object>> GetAttendanceHistoryAsync(int studentId, DateTime? fromDate, DateTime? toDate);
        Task<object> GetDailyAttendanceReportAsync(DateTime date);
        Task<bool> UpdateAttendanceAsync(int attendanceId, UpdateAttendanceDto dto);
        Task<bool> DeleteAttendanceAsync(int attendanceId);
    }
}
