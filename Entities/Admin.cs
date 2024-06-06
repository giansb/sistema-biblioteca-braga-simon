using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    public enum SystemRoles
    {
        viewer,
        editor,
        owner
    }
    public class Admin : User
    {
        public SystemRoles AcessLevel { get; set; }

        public Admin(string name, string email, int id, SystemRoles accessLevel) : base(name, email, id)
        {
            AcessLevel = accessLevel;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}\nNome: {Name}\nEmail: {Email}\nNivel de Acesso: {AcessLevel}");
        }
    }
}
