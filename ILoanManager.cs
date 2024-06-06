using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Entities;

namespace Biblioteca
{
    internal interface ILoanManager
    {
        public void RegisterLoan(Loan loan) {
        
        }

        public void RegisterReturn(string isbn, int userId)
        {

        }

        public void ListLoans()
        {

        }

        public void FindLoan(string isbn, int userId)
        {

        }
    }
}
