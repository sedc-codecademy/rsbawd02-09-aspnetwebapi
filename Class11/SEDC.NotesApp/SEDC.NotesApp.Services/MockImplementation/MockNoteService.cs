using SEDC.NotesApp.Dtos;
using SEDC.NotesApp.Services.Interfaces;

namespace SEDC.NotesApp.Services.MockImplementation;

public class MockNoteService : INoteService
{
    public void AddNote(AddNoteDto note)
    {
        throw new NotImplementedException();
    }

    public void DeleteNote(int id)
    {
        throw new NotImplementedException();
    }

    public List<NoteDto> GetAllNotes()
    {
        List<NoteDto> notes = new List<NoteDto>()
            {
                new NoteDto()
                {
                    Text = "NOTE 1 TEST",
                    Priority = 0,
                    Tag = Domain.Enums.Tag.Health,
                    UserFullName = "Milica"
                },
                new NoteDto()
                {
                    Text = "NOTE 2 TEST",
                    Priority = 0,
                    Tag = Domain.Enums.Tag.Health,
                    UserFullName = "Tamara"
                },
                new NoteDto()
                {
                    Text = "NOTE 3 TEST",
                    Priority = 0,
                    Tag = Domain.Enums.Tag.Health,
                    UserFullName = "Almir"
                }
            };

        return notes;
    }

    public List<NoteDto> GetAllUserNotes(int userId)
    {
        throw new NotImplementedException();
    }

    public NoteDto GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateNote(UpdateNoteDto note)
    {
        throw new NotImplementedException();
    }
}
