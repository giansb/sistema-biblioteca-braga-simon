using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entities;

namespace Biblioteca
{
    internal class Library : IBookManager
    {
        List<Book> books = [];
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("-LIVRO ADICIONADO COM SUCESSO-");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"LIVRO: {book.Title}");
            Console.WriteLine("---------------------------");
        }

        public void RemoveBook(string isbn)
        {
            string title = "";
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    title = books[i].Title;
                    books.Remove(books[i]);
                }
            }
            Console.WriteLine("-LIVRO ADICIONADO COM SUCESSO-");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"LIVRO: {title}");
            Console.WriteLine("---------------------------");
        }

        public void ListBooks()
        {
            Console.WriteLine("-----LISTA DE LIVROS-----");
            Console.WriteLine("-------------------------");
            foreach (Book book in books)
            {
                book.DisplayDetails();
                Console.WriteLine("-------------------------");
            }
        }

        public void FindBook(string isbn)
        {
            foreach (Book book in books)
            {
                if(book.ISBN == isbn)
                {
                    book.DisplayDetails();
                }
            }
        }
    }
}
