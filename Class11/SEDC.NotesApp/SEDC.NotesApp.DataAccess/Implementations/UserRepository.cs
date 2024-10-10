using SEDC.NotesApp.DataAccess.Interfaces;
using SEDC.NotesApp.Domain.Models;

namespace SEDC.NotesApp.DataAccess.Implementations
{
    public class UserRepository : IUserRepository
    {
        private NotesAppDbContext _notesAppDbContext;

        public UserRepository(NotesAppDbContext notesAppDbContext)
        {
            _notesAppDbContext = notesAppDbContext;
        }

        public void Add(User entity)
        {
            _notesAppDbContext.Users.Add(entity);
            _notesAppDbContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _notesAppDbContext.Users
                .FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByUsername(string username)
        {
           return _notesAppDbContext.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public User LoginUser(string username, string hashedPassword)
        {
            return _notesAppDbContext.Users
                .Where(x => x.Username.ToLower() == username.ToLower())
                .Where(x => x.Password == hashedPassword)
                .FirstOrDefault();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
