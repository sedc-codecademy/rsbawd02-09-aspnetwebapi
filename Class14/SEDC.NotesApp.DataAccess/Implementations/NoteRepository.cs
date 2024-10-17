using Microsoft.EntityFrameworkCore;
using SEDC.NotesApp.Domain.Models;

namespace SEDC.NotesApp.DataAccess.Implementations
{
    public class NoteRepository : IRepository<Note>
    {
        private NotesAppDbContext _notesAppDbContext;

        public NoteRepository(NotesAppDbContext notesAppDbContext) //DI
        {
        }

        public void Add(Note entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Note entity)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetAll()
        {
            throw new NotImplementedException();
        }

        public Note GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Note entity)
        {
            throw new NotImplementedException();
        }
    }
}
