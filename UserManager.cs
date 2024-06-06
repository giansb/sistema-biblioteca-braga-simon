using Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class UserManager : IUserManager
    {
        public List<User> Users { get; set; }

        public UserManager()
        {
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public User FindUser(int id)
        {
            return Users.Find(x => x.Id == id);
        }

        public void ListUsers()
        {
            Users.ForEach(x => x.DisplayDetails());
        }

        public void RemoveUser(int id)
        {
            Users.RemoveAll(x => x.Id == id);
        }
    }
}
