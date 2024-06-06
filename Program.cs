using Biblioteca;
using Biblioteca.Entities;

Book book = new Book("A Biblioteca da Meia-noite", "Matt Haig", "0000");

book.DisplayDetails();

Library lib = new Library();

lib.AddBook(book);
lib.ListBooks();
lib.RemoveBook("0000");
lib.ListBooks();
