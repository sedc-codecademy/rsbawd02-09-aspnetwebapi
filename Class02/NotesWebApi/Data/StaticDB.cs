using NotesWebApi.Models;

namespace NotesWebApi.Data;

public static class StaticDB
{
    public static List<NoteItem> SimpleNotes = new List<NoteItem>()
    {
        new NoteItem()
        {
            Id = 1,
            Content = "Do the homework",
            DateTime = DateTime.UtcNow.AddDays(-10),
        },

        new NoteItem()
        {
            Id = 2,
            Content = "Go to the gym",
            DateTime = DateTime.UtcNow.AddDays(-10),
        },

        new NoteItem()
        {
            Id = 3,
            Content = "Buy milk",
            DateTime = DateTime.UtcNow.AddDays(-10),
        }
    };
}
