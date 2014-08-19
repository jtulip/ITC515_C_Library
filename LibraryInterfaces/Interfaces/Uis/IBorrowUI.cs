using System;
using System.Collections.Generic;

using Library.Interfaces.Controls;
using Library.Interfaces.Entities;

namespace Library.Interfaces.Uis
{
    public interface IBorrowUI
    {
        void initialise(IBorrowCTL control);

        void setState(BorrowCTLConstants.State state);

        void displayBorrowerDetails(IMember borrower);

        void scanBook();

        void displayBook(IBook book);

        void displayPendingList(List<ILoan> pendingList);

        void displayCompletedList(List<ILoan> pendingList);

        void printLoanSlip();

    }
}
