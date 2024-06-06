namespace Biblioteca.Entities
{
    internal class Book
    {
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public string ISBN { get; protected set; }

        public Book(string title, string author, string isbm)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbm;
        }

        public virtual void DisplayDetails()
        {

            Console.WriteLine($"TITULO: {this.Title}");
            Console.WriteLine($"AUTOR: {this.Author}");
            Console.WriteLine($"ISBN: {this.ISBN}");
        }



    }
}
