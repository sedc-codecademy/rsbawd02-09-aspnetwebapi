using NotesAndTagsApp.Models.Base;

namespace NotesAndTagsApp.Models;

public class Tag : BaseEntity
{
    public string Name { get; set; }
    public string Color { get; set; }
}
