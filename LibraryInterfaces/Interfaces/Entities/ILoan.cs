using System;

namespace Library.Interfaces.Entities
{
    public interface ILoan
    {
        void Commit();

        void Complete();

        bool IsOverDue
        {
            get;
        }

        bool CheckOverDue(DateTime currentDate);

        IMember Borrower
        {
            get;
        }

        IBook Book
        {
            get;
        }

        int ID
        {
            get;
        }

        LoanConstants.LoanState State
        {
            get;
        }
    }
}
