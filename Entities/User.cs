using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    public class User
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public int Id { get; private set; }

        public User(string name, string email, int id)
        {
            Name = name;
            Email = email;
            Id = id;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}\nNome: {Name}\nEmail: {Email}");
        }
    }
}
