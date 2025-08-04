using RegisterAPII.DTOs;

namespace RegisterAPII.Interfaces
{
    public interface IAbsenceRepository
    {
        Task<IEnumerable<AbsenceRecordDto>> GetAllAsync();
        Task<AbsenceRecordDto?> GetByIdAsync(int id);
        Task AddAsync(CreateAbsenceRecordDto dto);
        Task DeleteAsync(int id);
    }
}
