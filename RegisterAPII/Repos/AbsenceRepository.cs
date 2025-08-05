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

        public async Task<IEnumerable<object>> GetFilteredAbsencesAsync(string? grade = null, string? className = null, int? session = null, DateTime? date = null)
        {
            var query = _context.AbsenceRecords
                .Join(_context.StudentProfiles, 
                    ar => ar.StudentId, 
                    sp => sp.Id.ToString(), 
                    (ar, sp) => new { AbsenceRecord = ar, Student = sp })
                .Join(_context.ClassRooms,
                    combined => combined.Student.ClassId,
                    cr => cr.Id,
                    (combined, cr) => new { combined.AbsenceRecord, combined.Student, Class = cr })
                .Join(_context.Grades,
                    combined => combined.Class.GradeId,
                    g => g.Id,
                    (combined, g) => new
                    {
                        Id = combined.AbsenceRecord.Id,
                        StudentId = combined.AbsenceRecord.StudentId,
                        StudentName = combined.AbsenceRecord.StudentName,
                        Date = combined.AbsenceRecord.Date,
                        Session = combined.AbsenceRecord.Session,
                        ClassId = combined.AbsenceRecord.ClassId,
                        ClassName = combined.Class.Name,
                        GradeName = g.Name,
                        RecordedAt = DateTime.Now // You might want to add this field to the AbsenceRecord model
                    });

            // Apply filters
            if (!string.IsNullOrEmpty(grade))
            {
                query = query.Where(x => x.GradeName == grade);
            }

            if (!string.IsNullOrEmpty(className))
            {
                query = query.Where(x => x.ClassName == className);
            }

            if (session.HasValue)
            {
                query = query.Where(x => x.Session == session.Value);
            }

            if (date.HasValue)
            {
                query = query.Where(x => x.Date.Date == date.Value.Date);
            }

            return await query.OrderByDescending(x => x.Date).ToListAsync();
        }

        public async Task<object> GetGradesAndClassesAsync()
        {
            var gradesWithClasses = await _context.Grades
                .Select(g => new
                {
                    GradeName = g.Name,
                    Classes = _context.ClassRooms
                        .Where(c => c.GradeId == g.Id)
                        .Select(c => c.Name)
                        .ToList()
                })
                .ToListAsync();

            return gradesWithClasses;
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
