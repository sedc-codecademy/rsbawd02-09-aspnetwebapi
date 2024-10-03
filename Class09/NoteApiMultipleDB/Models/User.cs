namespace NoteApiMultipleDB.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? UserName { get; set; }

    public int? Age { get; set; }

    public virtual List<Note> Notes { get; set; } = new List<Note>();
}
