using Look_For_It.Db.Models;
using System;
using System.Collections.Generic;
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
    }

    public interface IUsersRepository
    {
        public List<User> GetUsers();
        public void Add(User user);
    }
}
