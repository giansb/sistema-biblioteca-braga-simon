using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entities;

namespace Biblioteca
{
    internal class LoanManager : ILoanManager
    {
        public List<Loan> ListaEmprestimos = [];


        public void RegisterLoan(Loan loan)
        {
            ListaEmprestimos.Add(loan);
            Console.WriteLine("----EMPRÉSTIMO REGISTRADO COM SUCESSO----");
            loan.DisplayDetails();
            Console.WriteLine("-----------------------------------------");
        }

        public void RegisterReturn(string isbn, int userId)
        {
            for(var i = 0; i < ListaEmprestimos.Count; i++)
            {
                if (ListaEmprestimos[i].Book.ISBN == isbn)
                {
                    ListaEmprestimos[i].DisplayDetails();
                } else
                {
                    Console.WriteLine($"Não foi encontrado nenhum registro com essas informações.");

                }
            }
            
        }

        public void ListLoans()
        {

        }

        public void FindLoan(string isbn, int userId)
        {

        }

    }
}
