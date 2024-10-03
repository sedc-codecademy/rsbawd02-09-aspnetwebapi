namespace NoteApiMultipleDB.Models;
public class Note
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public int Priority { get; set; }

    public int? Tag { get; set; }

    public int UserId { get; set; }
}
