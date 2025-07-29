using RegisterAPII.DTOs;

namespace RegisterAPII.Interfaces
{
    public interface IAttendanceRepository
    {
        Task SaveAttendanceAsync(SaveAttendanceDto dto);
        Task AddNoteAsync(NoteInputModel model);
    }
}
