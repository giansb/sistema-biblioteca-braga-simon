using Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Screens
    {
        private UserManager userManager;
        private Library library;
        public Screens() 
        {
            userManager = new UserManager();
            library = new Library();
        }

        private void InputMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }
        public void Run()
        {
            while(true)
            {
                Console.WriteLine("1 - Sistema de Usuários");
                Console.WriteLine("2 - Sistema de Livros");
                Console.WriteLine("0 - Fechar Biblioteca Mágica");
                InputMessage("Digite o número da interação que deseja: ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 0) break;

                this.RenderScreen(answer);
            }
        }

        public void RenderScreen(int option)
        {
            switch (option)
            {
                case 1:
                    UserSystem();
                    break;
                case 2:
                    BookSystem();
                    break;
            }
        }

        public void UserSystem() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Bem vindo ao Sistema de Usuários]\n");
            Console.ResetColor();

            Console.WriteLine("1 - Procurar Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Adicionar Usuário");
            Console.WriteLine("4 - Remover Usuário");
            InputMessage("Digite o número da ação que deseja executar: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    FindUserScreen();
                    break;
                case 2:
                    ListUsersScreen();
                    break;
                case 3:
                    AddUserScreen();
                    break;
                case 4:
                    RemoveUserScreen();
                    break;
            }

        }
        private void FindUserScreen()
        {
            InputMessage("Digite o id do usuário: ");
            int id = Convert.ToInt32(Console.ReadLine());
            User result = userManager.FindUser(id);
            result.DisplayDetails();
        }
        private void ListUsersScreen()
        {
            Console.WriteLine("Lista de Usuários\n");
            Console.WriteLine("------------------------------");
            userManager.ListUsers();
            Console.WriteLine("------------------------------");
        }
        private void AddUserScreen()
        {
            Console.WriteLine("----------------");
            InputMessage("Digite o nome do usuário: ");
            string name = Console.ReadLine();

            InputMessage("Digite o email: ");
            string email = Console.ReadLine();

            InputMessage("Digite o id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            User newUser = new User(name, email, id);
            userManager.AddUser(newUser);
        }
        private void RemoveUserScreen()
        {
            Console.WriteLine("--------");
            InputMessage("Digite o Id do usuário que deseja remover: ");
            int id = Convert.ToInt32(Console.ReadLine());

            userManager.RemoveUser(id);
        }

        public void BookSystem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Bem vindo ao Sistema de Livros]");
            Console.ResetColor();

            Console.WriteLine("1 - Procurar Livro");
            Console.WriteLine("2 - Listar Livro");
            Console.WriteLine("3 - Adicionar Livro");
            Console.WriteLine("4 - Remover Livro");
            InputMessage("Digite o número da ação que deseja executar: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch(answer)
            {
                case 1:
                    FindBookScreen();
                    break;
                case 2:
                    ListBooksScreen();
                    break;
                case 3:
                    AddBookScreen();
                    break;
                case 4:
                    RemoveBookScreen();
                    break;
            }

        }

        private void FindBookScreen()
        {
            Console.WriteLine("--------------");
            InputMessage("Digite o ISBN do livro que procura: ");
            string isbn = Console.ReadLine();

            library.FindBook(isbn);
        }
        private void ListBooksScreen()
        {
            Console.WriteLine("--------------------");
            library.ListBooks();
        }
        private void AddBookScreen()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Adicionar 1 - Livro 2 - Ebook");
            int option = Convert.ToInt32(Console.ReadLine());

            Book book;

            InputMessage("Digite o nome: ");
            string name = Console.ReadLine();

            InputMessage("Digite o autor: ");
            string author = Console.ReadLine();

            InputMessage("Digite o ibsm: ");
            string ibsm = Console.ReadLine();

            if (option == 1)
            {
                book = new Book(name, author, ibsm);
            } else
            {
                InputMessage("Digite o Tipo de Arquivo (PDF/TXT/DOCS): ");
                string fileType = Console.ReadLine();

                InputMessage("Digite o tamanho do arquivo: ");
                double fileSize = Convert.ToDouble(Console.ReadLine());

                book = new Ebook(fileSize, fileType, name, author, ibsm);
            }
            library.AddBook(book);

        }
        private void RemoveBookScreen()
        {
            InputMessage("Digite o ibsm do livro que deseja remover: ");
            string ibsm = Console.ReadLine();
            library.RemoveBook(ibsm);
        }
    }
}
