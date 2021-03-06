using DemoGraphQLTest.Abstraction.BookLoan.Model;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoGraphQLTest.Abstraction.BookLoan.Service
{
  public   interface ILoanService
    {
        Task<List<string>> AddLoan(Loan loan);

        Task<List<string>> UpdateLoan(Loan loan);
        Task<List<string>> DeleteLoan(int id);
        Task<Loan> GetLoan(int id);
        Task<IEnumerable<Loan>> GetLoans();
    }
}
