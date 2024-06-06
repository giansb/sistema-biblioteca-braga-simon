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

        public void Run()
        {
            while(true)
            {
                Console.WriteLine("1 - Sistema de Usuários");
                Console.WriteLine("2 - Sistema de Livros");
                Console.Write("Digite o número da interação que deseja: ");
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
            Console.Write("Digite o número da ação que deseja executar: ");
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
            Console.Write("Digite o id do usuário: ");
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
            Console.Write("Digite o nome do usuário: ");
            string name = Console.ReadLine();

            Console.Write("Digite o email: ");
            string email = Console.ReadLine();

            Console.Write("Digite o id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            User newUser = new User(name, email, id);
            userManager.AddUser(newUser);
        }
        private void RemoveUserScreen()
        {
            Console.WriteLine("--------");
            Console.Write("Digite o Id do usuário que deseja remover: ");
            int id = Convert.ToInt32(Console.ReadLine());

            userManager.RemoveUser(id);
        }

        public void BookSystem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Bem vindo ao Sistema de Livros]");
            Console.ResetColor();
        }
    }
}
