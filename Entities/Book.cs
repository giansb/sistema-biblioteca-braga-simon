using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    internal class Book
    {
        public string Title { get;  protected set; }
        public string Author { get; protected set; }
        public string ISBN { get; protected set; }

        public Book(string title, string author, string isbm)
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
