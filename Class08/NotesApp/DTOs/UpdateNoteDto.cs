
namespace NotesAndTagsApp.DTOs;

public class UpdateNoteDto
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int Priority { get; set; }
    public int UserId { get; set; }
}
