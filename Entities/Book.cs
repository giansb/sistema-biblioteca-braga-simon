using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    internal class Book
    {
        protected string Title { get;  private set; }
        protected string Author { get; private set; }
        protected int ISBN { get; private set; }

        public Book(string title, string author, int isbm)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbm;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("-----DETALHES DO LIVRO-----");
            Console.WriteLine($"TITULO: {this.Title}");
            Console.WriteLine($"AUTOR: {this.Author}");
            Console.WriteLine($"ISBN: {this.ISBN}");
        }



    }
}
