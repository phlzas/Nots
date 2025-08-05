using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;
using System.Text.Json;

namespace RegisterAPII.Repos
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;
        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveAttendanceAsync(SaveAttendanceDto dto)
        {
            var record = new AttendanceRecord
            {
                StudentId = dto.StudentId,
                Date = dto.Date.Date,
                SessionNumber = dto.SessionNumber,
                IsPresent = dto.IsPresent,
                NoteId = dto.NoteId,
            };

            _context.AttendanceRecords.Add(record);
            await _context.SaveChangesAsync();

          
            var absentSessions = await _context.AttendanceRecords
                .Where(a => a.StudentId == dto.StudentId && a.Date == dto.Date.Date && a.IsPresent == false)
                .CountAsync();

            if (absentSessions >= 2)
            {
                var student = await _context.StudentProfiles.FindAsync(dto.StudentId);
                if (student != null)
                {
                    student.DaysAbsent += 1;
                    await _context.SaveChangesAsync();
                }
            }
        }


        public async Task AddNoteAsync(NoteInputModel model)
        {
            // First, verify the student exists
            var studentExists = await _context.StudentProfiles.AnyAsync(s => s.Id == model.StudentId);
            if (!studentExists)
            {
                throw new ArgumentException($"Student with ID {model.StudentId} does not exist.");
            }

            var record = await _context.AttendanceRecords.FirstOrDefaultAsync(a =>
                a.StudentId == model.StudentId &&
                a.Date.Date == model.Date.Date);

            if (record == null)
            {
                record = new AttendanceRecord
                {
                    StudentId = model.StudentId,
                    Date = model.Date,
                    SessionNumber = 1,
                    IsPresent = true
                };
                _context.AttendanceRecords.Add(record);
                await _context.SaveChangesAsync();
            }

            var note = new BehaviorNote
            {
                AttendanceRecordId = record.Id,
                Title = model.Title ?? "",
                Description = model.Description ?? "",
                NoteType = model.NoteType ?? "general",
                ImageUrl = model.ImageUrl ?? "",
                gen = "system" // Default value for the gen property
            };

            _context.BehaviorNotes.Add(note);
            await _context.SaveChangesAsync();

            var student = await _context.StudentProfiles.FindAsync(model.StudentId);
            if (student != null && !string.IsNullOrEmpty(model.NoteType))
            {
                var newNote = new
                {
                    Title = model.Title ?? "",
                    Description = model.Description ?? "",
                    Date = model.Date.ToString("yyyy-MM-dd"),
                    ImageUrl = model.ImageUrl ?? ""
                };

                if (model.NoteType.ToLower() == "good")
                {
                    var existingNotes = string.IsNullOrEmpty(student.GoodNotesJson)
                        ? new List<object>()
                        : JsonSerializer.Deserialize<List<object>>(student.GoodNotesJson) ?? new List<object>();

                    existingNotes.Add(newNote);
                    student.GoodNotesJson = JsonSerializer.Serialize(existingNotes);
                }
                else if (model.NoteType.ToLower() == "bad")
                {
                    var existingNotes = string.IsNullOrEmpty(student.BadNotesJson)
                        ? new List<object>()
                        : JsonSerializer.Deserialize<List<object>>(student.BadNotesJson) ?? new List<object>();

                    existingNotes.Add(newNote);
                    student.BadNotesJson = JsonSerializer.Serialize(existingNotes);
                }

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<object>> GetAttendanceHistoryAsync(int studentId, DateTime? fromDate, DateTime? toDate)
        {
            var query = _context.AttendanceRecords
                .Where(a => a.StudentId == studentId);

            if (fromDate.HasValue)
                query = query.Where(a => a.Date >= fromDate.Value.Date);

            if (toDate.HasValue)
                query = query.Where(a => a.Date <= toDate.Value.Date);

            return await query
                .OrderByDescending(a => a.Date)
                .Select(a => new
                {
                    a.Id,
                    a.Date,
                    a.SessionNumber,
                    a.IsPresent,
                    a.NoteId
                })
                .ToListAsync();
        }

        public async Task<object> GetDailyAttendanceReportAsync(DateTime date)
        {
            var attendanceRecords = await _context.AttendanceRecords
                .Where(a => a.Date.Date == date.Date)
                .ToListAsync();

            var totalStudents = await _context.StudentProfiles.CountAsync();
            var presentStudents = attendanceRecords.Count(a => a.IsPresent);
            var absentStudents = totalStudents - presentStudents;

            // Get student names for the attendance records
            var studentIds = attendanceRecords.Select(a => a.StudentId).Distinct().ToList();
            var students = await _context.StudentProfiles
                .Where(s => studentIds.Contains(s.Id))
                .ToDictionaryAsync(s => s.Id, s => s.Name);

            return new
            {
                Date = date.Date,
                TotalStudents = totalStudents,
                PresentStudents = presentStudents,
                AbsentStudents = absentStudents,
                AttendanceRecords = attendanceRecords.Select(a => new
                {
                    a.Id,
                    a.StudentId,
                    StudentName = students.ContainsKey(a.StudentId) ? students[a.StudentId] : "Unknown",
                    a.IsPresent,
                    a.SessionNumber
                })
            };
        }

        public async Task<bool> UpdateAttendanceAsync(int attendanceId, UpdateAttendanceDto dto)
        {
            var record = await _context.AttendanceRecords.FindAsync(attendanceId);
            if (record == null)
                return false;

            record.IsPresent = dto.IsPresent;
            record.Date = dto.Date;
            record.SessionNumber = dto.SessionNumber;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAttendanceAsync(int attendanceId)
        {
            var record = await _context.AttendanceRecords.FindAsync(attendanceId);
            if (record == null)
                return false;

            _context.AttendanceRecords.Remove(record);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}