namespace Library.Interfaces.Controls
{
    public interface IBorrowCTL
    {
        void Cancel();

        void CardScanned(int memberID);

        void BookScanned(int bookID);

        void ScanNext();

        void ScansCompleted();

        void RejectPendingList();

        void ConfirmPendingList();

        void BorrowUcEnded();

    }
}