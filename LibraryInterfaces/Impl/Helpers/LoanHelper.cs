using System;

using Library.Interfaces.Helpers;
using Library.Interfaces.Entities;
using Library.Impl.Entities;

namespace Library.Impl.Helpers
{
    public class LoanHelper : ILoanHelper
    {
        public ILoan MakeLoan(IBook book, IMember borrower, DateTime borrowDate, DateTime dueDate, int id)
        {
            return new Loan(book, borrower, borrowDate, dueDate, id);
        }
    }
}
