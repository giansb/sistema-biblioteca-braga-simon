using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    internal class Loan
    {
        public User User { get; protected set; }
        public Book Book { get; protected set; }
        public string LoanDate { get; protected set; }
        public string ReturnDate { get; protected set; }

        public void DisplayDetails()
        {
            Console.WriteLine("----DETALHES DO EMPRÉSTIMO----");
            Console.WriteLine($"USUÁRIO: {this.User}");
            Console.WriteLine($"LIVRO: {this.Book}");
            Console.WriteLine($"DATA DO EMPRÉSTIMO: {this.LoanDate}");
            Console.WriteLine($"DATA DE RETORNO: {this.ReturnDate}");
        }
    }
}
