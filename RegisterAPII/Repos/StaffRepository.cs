using Microsoft.EntityFrameworkCore;
using RegisterAPII.DTOs;
using RegisterAPII.Models;
using RegisterAPII.DATA;
using RegisterAPII.Interfaces;

namespace RegisterAPII.Repos
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ApplicationDbContext _context;

        public StaffRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<StaffDto> CreateStaffAttendanceAsync(CreateStaffAttendanceDto dto)
        {
            var staff = new Staff
            {
                EmployeeName = dto.EmployeeName,
                Department = dto.Department,
                Status = dto.Status,
                CheckInTime = dto.CheckInTime,
                CheckInMethod = dto.CheckInMethod,
                AccountId = dto.AccountId,
                RoleId = dto.RoleId,
                Date = DateTime.UtcNow.Date,
                CreatedAt = DateTime.UtcNow
            };

            _context.Staff.Add(staff);
            await _context.SaveChangesAsync();

            return MapToDto(staff);
        }

        public async Task<IEnumerable<StaffDto>> GetStaffAttendanceByDateAsync(DateTime date)
        {
            var staffList = await _context.Staff
                .Where(s => s.Date.Date == date.Date)
                .Include(s => s.Account)
                .Include(s => s.Role)
                .ToListAsync();

            return staffList.Select(MapToDto);
        }

        public async Task<IEnumerable<StaffDto>> GetStaffAttendanceByDepartmentAsync(string department, DateTime? date = null)
        {
            var query = _context.Staff.AsQueryable();

            if (!string.IsNullOrEmpty(department))
                query = query.Where(s => s.Department == department);

            if (date.HasValue)
                query = query.Where(s => s.Date.Date == date.Value.Date);

            var staffList = await query
                .Include(s => s.Account)
                .Include(s => s.Role)
                .ToListAsync();

            return staffList.Select(MapToDto);
        }

        public async Task<StaffDto> GetStaffAttendanceByIdAsync(int id)
        {
            var staff = await _context.Staff
                .Include(s => s.Account)
                .Include(s => s.Role)
                .FirstOrDefaultAsync(s => s.Id == id);

            return staff != null ? MapToDto(staff) : null;
        }

        public async Task<bool> UpdateStaffAttendanceAsync(int id, UpdateStaffAttendanceDto dto)
        {
            var staff = await _context.Staff.FindAsync(id);
            if (staff == null) return false;

            staff.Status = dto.Status;
            staff.CheckInTime = dto.CheckInTime;
            staff.CheckInMethod = dto.CheckInMethod;
            staff.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteStaffAttendanceAsync(int id)
        {
            var staff = await _context.Staff.FindAsync(id);
            if (staff == null) return false;

            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<StaffDto>> GetStaffAttendanceHistoryAsync(int accountId, DateTime? fromDate, DateTime? toDate)
        {
            var query = _context.Staff.Where(s => s.AccountId == accountId);

            if (fromDate.HasValue)
                query = query.Where(s => s.Date >= fromDate.Value.Date);

            if (toDate.HasValue)
                query = query.Where(s => s.Date <= toDate.Value.Date);

            var staffList = await query
                .Include(s => s.Account)
                .Include(s => s.Role)
                .OrderByDescending(s => s.Date)
                .ToListAsync();

            return staffList.Select(MapToDto);
        }

        private StaffDto MapToDto(Staff staff)
        {
            return new StaffDto
            {
                Id = staff.Id,
                EmployeeName = staff.EmployeeName,
                Department = staff.Department,
                Status = staff.Status,
                CheckInTime = staff.CheckInTime,
                CheckInMethod = staff.CheckInMethod,
                Date = staff.Date,
                AccountId = staff.AccountId,
                RoleId = staff.RoleId,
                CreatedAt = staff.CreatedAt
            };
        }
    }
}