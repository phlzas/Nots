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
            var record = await _context.AttendanceRecords.FirstOrDefaultAsync(a =>
                a.StudentId == model.StudentId &&
                a.SessionNumber == model.SessionNumber &&
                a.Date.Date == model.Date.Date);

            if (record == null)
            {
                record = new AttendanceRecord
                {
                    StudentId = model.StudentId,
                    Date = model.Date,
                    SessionNumber = model.SessionNumber,
                    IsPresent = true
                };
                _context.AttendanceRecords.Add(record);
                await _context.SaveChangesAsync();
            }

            var note = new BehaviorNote
            {
                AttendanceRecordId = record.Id,
                Title = model.Title,
                Description = model.Description,
                NoteType = model.NoteType,
                ImageUrl = model.ImageUrl
            };

            _context.BehaviorNotes.Add(note);
            await _context.SaveChangesAsync();

            var student = await _context.StudentProfiles.FindAsync(model.StudentId);
            if (student != null && !string.IsNullOrEmpty(model.NoteType))
            {
                var newNote = new
                {
                    Title = model.Title,
                    Description = model.Description,
                    Date = model.Date.ToString("yyyy-MM-dd"),
                    ImageUrl = model.ImageUrl
                };

                if (model.NoteType.ToLower() == "good")
                {
                    var existingNotes = string.IsNullOrEmpty(student.GoodNotesJson)
                        ? new List<object>()
                        : JsonSerializer.Deserialize<List<object>>(student.GoodNotesJson)!;

                    existingNotes.Add(newNote);
                    student.GoodNotesJson = JsonSerializer.Serialize(existingNotes);
                }
                else if (model.NoteType.ToLower() == "bad")
                {
                    var existingNotes = string.IsNullOrEmpty(student.BadNotesJson)
                        ? new List<object>()
                        : JsonSerializer.Deserialize<List<object>>(student.BadNotesJson)!;

                    existingNotes.Add(newNote);
                    student.BadNotesJson = JsonSerializer.Serialize(existingNotes);
                }

                await _context.SaveChangesAsync();
            }
        }

    }
}