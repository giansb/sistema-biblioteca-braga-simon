using Biblioteca.Entities;

namespace Biblioteca
{
    internal interface IUserManager
    {
        public void AddUser(User user);
        public void RemoveUser(int id);
        public void ListUsers();
        public User FindUser(int id);
    }
}
