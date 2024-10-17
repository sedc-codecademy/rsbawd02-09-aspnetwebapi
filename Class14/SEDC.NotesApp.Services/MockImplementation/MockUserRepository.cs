using SEDC.NotesApp.DataAccess;
using SEDC.NotesApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppTests.FakeRepositories
{
    public class MockUserRepository : IRepository<User>
    {
        private List<User> users;
        public MockUserRepository()
        {
            users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Age = 22,
                    Username = "Boby_123"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Zoka",
                    LastName = "Zoksi",
                    Age = 35,
                    Username = "Zoksi_123"
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Miki",
                    LastName = "Milan",
                    Age = 45,
                    Username = "miki_123"
                }
            };
        }
        public void Add(User entity)
        {
           users.Add(entity);
        }

        public void Delete(User entity)
        {
            users.Remove(entity);
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            return users.SingleOrDefault(user => user.Id == id);
        }

        public void Update(User entity)
        {
            users[users.IndexOf(entity)] = entity;
        }
    }
}
