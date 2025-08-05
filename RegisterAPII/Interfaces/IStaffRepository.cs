using RegisterAPII.DTOs;

namespace RegisterAPII.Interfaces
{
    public interface IStaffRepository
    {
        Task<StaffDto> CreateStaffAttendanceAsync(CreateStaffAttendanceDto dto);
        Task<IEnumerable<StaffDto>> GetStaffAttendanceByDateAsync(DateTime date);
        Task<IEnumerable<StaffDto>> GetStaffAttendanceByDepartmentAsync(string department, DateTime? date = null);
        Task<StaffDto> GetStaffAttendanceByIdAsync(int id);
        Task<bool> UpdateStaffAttendanceAsync(int id, UpdateStaffAttendanceDto dto);
        Task<bool> DeleteStaffAttendanceAsync(int id);
        Task<IEnumerable<StaffDto>> GetStaffAttendanceHistoryAsync(int accountId, DateTime? fromDate, DateTime? toDate);
    }
}