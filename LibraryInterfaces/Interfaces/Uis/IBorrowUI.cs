using System;
using System.Collections.Generic;

using Library.Interfaces.Controls;
using Library.Interfaces.Entities;

namespace Library.Interfaces.Uis
{
    public interface IBorrowUI
    {
        void Initialise(IBorrowCTL control);

        void SetState(BorrowCTLConstants.State state);

        void DisplayBorrowerDetails(IMember borrower);

        void ScanBook();

        void DisplayBook(IBook book);

        void DisplayPendingList(List<ILoan> pendingList);

        void DisplayCompletedList(List<ILoan> pendingList);

        void PrintLoanSlip();

    }
}
