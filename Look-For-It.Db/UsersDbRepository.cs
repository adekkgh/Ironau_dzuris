using Look_For_It.Db.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Look_For_It.Db
{
    public class UsersDbRepository : IUsersRepository
    {
        private readonly DatabaseContext databaseContext;

        public UsersDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<User> GetUsers()
        {
            return databaseContext.Users.ToList();
        }

        public void Add(User user)
        {
            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();
        }

        public User FindByEmail(string email)
        {
            return databaseContext.Users.FirstOrDefault(u => u.Email == email);
        }

        public bool IsEmailValid(string email)
        {
            var user = databaseContext.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public bool IsPasswordValid(string email, string password)
        {
            var user = databaseContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }

    public interface IUsersRepository
    {
        public List<User> GetUsers();
        public void Add(User user);
        public User FindByEmail(string email);
        public bool IsEmailValid(string email);
        public bool IsPasswordValid(string email, string password);
    }
}
