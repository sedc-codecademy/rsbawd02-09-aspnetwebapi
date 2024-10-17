using SEDC.NotesApp.DataAccess;
using SEDC.NotesApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppTests.FakeRepositories
{
    public class MockNotesRepository : IRepository<Note>
    {
        private List<Note> notes;

        public MockNotesRepository()
        {
            notes = new List<Note>()
                {
                    new Note()
                    {
                        Id = 1,
                        UserId = 1,
                        Priority = SEDC.NotesApp.Domain.Enums.Priority.High,
                        Tag = SEDC.NotesApp.Domain.Enums.Tag.Health,
                        Text = "Do something X"
                    },
                    new Note()
                    {
                        Id = 2,
                        UserId = 1,
                        Priority = SEDC.NotesApp.Domain.Enums.Priority.Medium,
                        Tag = SEDC.NotesApp.Domain.Enums.Tag.SocialLife,
                        Text = "Do something else!"
                    },
                    new Note()
                    {
                        Id = 3,
                        UserId = 1,
                        Priority = SEDC.NotesApp.Domain.Enums.Priority.High,
                        Tag = SEDC.NotesApp.Domain.Enums.Tag.SocialLife,
                        Text = "Do something else! 3333"
                    },
                    new Note()
                    {
                        Id = 4,
                        UserId = 2,
                        Priority = SEDC.NotesApp.Domain.Enums.Priority.High,
                        Tag = SEDC.NotesApp.Domain.Enums.Tag.SocialLife,
                        Text = "Go to mechanic"
                    },
                    new Note()
                    {
                        Id = 5,
                        UserId = 2,
                        Priority = SEDC.NotesApp.Domain.Enums.Priority.High,
                        Tag = SEDC.NotesApp.Domain.Enums.Tag.Work,
                        Text = "Work on the Item 2"
                    }
                };
        }
        public void Add(Note entity)
        {
            notes.Add(entity);
        }

        public void Delete(Note entity)
        {
            notes.Remove(entity);
        }

        public List<Note> GetAll()
        {
            return notes;
        }

        public Note GetById(int id)
        {
            return notes.SingleOrDefault(note => note.Id == id);
        }

        public void Update(Note entity)
        {
            notes[notes.IndexOf(entity)] = entity;
        }
    }
}
