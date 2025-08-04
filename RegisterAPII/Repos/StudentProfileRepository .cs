// In Repos/StudentProfileRepository.cs
using Microsoft.EntityFrameworkCore;
using RegisterAPII.DATA;
using RegisterAPII.DTOs;
using RegisterAPII.Interfaces;
using RegisterAPII.Models;
using System.Text.Json;

namespace RegisterAPII.Repos
{
    public class StudentProfileRepository : IStudentProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<StudentProfileDto>> GetAllAsync()
        {
            // The .Select() method is very efficient. It tells the database
            // to only query the columns needed for the DTO.
            return await _context.StudentProfiles
                .Select(student => new StudentProfileDto
                {
                    // Map the entity properties to the DTO properties
                    Id = student.Id,
                    Name = student.Name,
                    Email = student.Email,
                    PhoneNumber = student.PhoneNumber,
                    Age = student.Age,
                    City = student.City,
                    Country = student.Country,
                    DaysAbsent = student.DaysAbsent,
                    ClassId = student.ClassId
                })
                .ToListAsync(); // Executes the query and returns the list
        }


        // GET a single profile by ID
        public async Task<StudentProfileDto?> GetByIdAsync(int id)
        {
            var student = await _context.StudentProfiles.FindAsync(id);
            if (student == null) return null;

            // Map Entity to DTO
            return new StudentProfileDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Age = student.Age,
                City = student.City,
                Country = student.Country,
                DaysAbsent = student.DaysAbsent,
                GoodNotes = JsonSerializer.Deserialize<List<string>>(student.GoodNotesJson) ?? new(),
                BadNotes = JsonSerializer.Deserialize<List<string>>(student.BadNotesJson) ?? new(),
                ClassId = student.ClassId
            };
        }

        // CREATE a new profile
        public async Task<StudentProfile> CreateAsync(StudentProfileDto dto)
        {
            var student = new StudentProfile
            {
                Id = dto.Id,
                Name = dto.Name,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Age = dto.Age,
                City = dto.City,
                Country = dto.Country,
                DaysAbsent = dto.DaysAbsent,
                GoodNotesJson = JsonSerializer.Serialize(dto.GoodNotes),
                BadNotesJson = JsonSerializer.Serialize(dto.BadNotes),
                CreatedAt = DateTime.UtcNow,
                ClassId = dto.ClassId
            };

            _context.StudentProfiles.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        // UPDATE a full profile
        public async Task<StudentProfileDto?> UpdateAsync(int id, StudentProfileDto dto)
        {
            var student = await _context.StudentProfiles.FindAsync(id);
            if (student == null) return null; // Not found

            // Map all updatable fields from DTO to the entity
            student.Id = dto.Id;
            student.Name = dto.Name;
            student.PhoneNumber = dto.PhoneNumber;
            student.Age = dto.Age;
            student.City = dto.City;
            student.Country = dto.Country;
            student.DaysAbsent = dto.DaysAbsent;
            student.GoodNotesJson = JsonSerializer.Serialize(dto.GoodNotes);
            student.BadNotesJson = JsonSerializer.Serialize(dto.BadNotes);

            await _context.SaveChangesAsync();

            // Return the updated profile by calling GetByIdAsync again
            return await GetByIdAsync(id);
        }

        // DELETE a profile
        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _context.StudentProfiles.FindAsync(id);
            if (student == null) return false; // Not found

            _context.StudentProfiles.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }

        // UPDATE only the notes
        public async Task<bool> UpdateNotesAsync(int id, NotesUpdateDto dto)
        {
            var student = await _context.StudentProfiles.FindAsync(id);
            if (student == null) return false; // Not found

            student.GoodNotesJson = JsonSerializer.Serialize(dto.GoodNotes);
            student.BadNotesJson = JsonSerializer.Serialize(dto.BadNotes);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}