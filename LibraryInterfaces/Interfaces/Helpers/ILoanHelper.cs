using System;

using Library.Interfaces.Entities;

namespace Library.Interfaces.Helpers
{
    public interface ILoanHelper
    {
        ILoan MakeLoan(IBook book, IMember borrower, DateTime borrowDate, DateTime dueDate, int id);
    }
}
