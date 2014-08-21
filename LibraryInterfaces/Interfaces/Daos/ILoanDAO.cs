using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;
using Library.Interfaces.Helpers;

namespace Library.Interfaces.Daos
{
    public interface ILoanDAO
    {
        void CreateNewPendingList(IMember borrower);

        ILoan CreatePendingLoan(IMember borrower, IBook book, DateTime borrowDate, DateTime dueDate);

        List<ILoan> GetPendingList(IMember borrower);

        void CommitPendingLoans(IMember borrower);

        void ClearPendingLoans(IMember borrower);

        ILoan GetLoanByID(int id);

        ILoan GetLoanByBook(IBook book);

        List<ILoan> LoanList
        {
            get;
        }

        List<ILoan> FindLoansByBorrower(IMember borrower);

        List<ILoan> FindLoansByBookTitle(string title);

        void UpdateOverDueStatus(DateTime currentDate);

        List<ILoan> FindOverDueLoans();

    }
}
