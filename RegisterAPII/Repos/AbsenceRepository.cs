using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;

namespace RegisterAPII.Repos
{
    public class AbsenceRepository : IAbsenceRepository
    {
        private readonly ApplicationDbContext _context;
        public AbsenceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AbsenceRecordDto>> GetAllAsync()
        {
            return await _context.AbsenceRecords
                .Select(a => new AbsenceRecordDto
                {
                    Id = a.Id,
                    StudentId = a.StudentId,
                    StudentName = a.StudentName,
                    Date = a.Date,
                    Session = a.Session,
                    ClassId = a.ClassId
                })
                .ToListAsync();
        }

        public async Task<AbsenceRecordDto?> GetByIdAsync(int id)
        {
            var a = await _context.AbsenceRecords.FindAsync(id);
            if (a == null) return null;
            return new AbsenceRecordDto
            {
                Id = a.Id,
                StudentId = a.StudentId,
                StudentName = a.StudentName,
                Date = a.Date,
                Session = a.Session,
                ClassId = a.ClassId
            };
        }

        public async Task AddAsync(CreateAbsenceRecordDto dto)
        {
            var record = new AbsenceRecord
            {
                StudentId = dto.StudentId,
                StudentName = dto.StudentName,
                Date = dto.Date,
                Session = dto.Session,
                ClassId = dto.ClassId
            };
            _context.AbsenceRecords.Add(record);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var record = await _context.AbsenceRecords.FindAsync(id);
            if (record != null)
            {
                _context.AbsenceRecords.Remove(record);
                await _context.SaveChangesAsync();
            }
        }
    }
}
