using NoteApiMultipleDB.Models;

namespace NoteApiMultipleDB.Abstraction
{
    public interface IUserRepository
    {
        void Add(User entity);
        List<User> GetAll();
        void Delete(User entity);
        User GetById(int id);
        void Update(User model);
    }
}
