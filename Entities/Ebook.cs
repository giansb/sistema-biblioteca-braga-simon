using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    internal class Ebook : Book
    {
        protected double FileSize { get; private set; }
        protected string FileFormat { get; private set; }
        public Ebook(double filesize, string fileformat, string title, string author, int isbm) : base(title, author, isbm)
        {
            this.FileSize = filesize;
            this.FileFormat = fileformat;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("-----DETALHES DO EBOOK-----");
            Console.WriteLine($"TITULO: {this.Title}");
            Console.WriteLine($"AUTOR: {this.Author}");
            Console.WriteLine($"TAMANHO DO ARQUIVO: {this.FileSize}");
            Console.WriteLine($"FORMATO DO ARQUIVO: {this.FileFormat}");
            Console.WriteLine($"ISBN: {this.ISBN}");
        }
    }
}
