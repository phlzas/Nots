// In Interfaces/IStudentProfileRepository.cs
using RegisterAPII.DTOs;
using RegisterAPII.Models;

namespace RegisterAPII.Interfaces
{
    public interface IStudentProfileRepository
    {
        Task<IEnumerable<StudentProfileDto>> GetAllAsync();
        Task<StudentProfileDto?> GetByIdAsync(int id);
        Task<StudentProfile> CreateAsync(StudentProfileDto dto);
        Task<StudentProfileDto?> UpdateAsync(int id, StudentProfileDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateNotesAsync(int id, NotesUpdateDto dto);
    }
}