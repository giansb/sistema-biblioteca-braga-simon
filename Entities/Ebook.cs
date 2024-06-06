using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    internal class Ebook : Book
    {
        public double FileSize { get; protected set; }
        public string FileFormat { get; protected set; }
        public Ebook(double filesize, string fileformat, string title, string author, string isbm) : base(title, author, isbm)
        {
            this.FileSize = filesize;
            this.FileFormat = fileformat;

        }

        public override void DisplayDetails()
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
