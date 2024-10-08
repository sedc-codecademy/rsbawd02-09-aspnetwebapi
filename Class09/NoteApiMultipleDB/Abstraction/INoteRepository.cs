﻿using NoteApiMultipleDB.Models;

namespace NoteApiMultipleDB.Abstraction
{
    public interface INoteRepository
    {
        void Add(Note entity);
        List<Note> GetAll();
        void Delete(Note entity);
        Note GetById(int id);   
        void Update(Note model);
    }
}
