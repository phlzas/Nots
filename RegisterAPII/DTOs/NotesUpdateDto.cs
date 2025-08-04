// In DTOs/NotesUpdateDto.cs
namespace RegisterAPII.DTOs
{
    public class NotesUpdateDto
    {
        public List<string> GoodNotes { get; set; } = new();
        public List<string> BadNotes { get; set; } = new();
    }
}// In DTOs/NotesUpdateDto.cs
