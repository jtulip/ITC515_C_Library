
namespace Library.Interfaces.Entities
{
    public interface IBook
    {
        void borrow(ILoan loan);

        ILoan Loan
        {
            get;
        }

        void returnBook(bool damaged);

        void lose();

        void repair();

        void dispose();

        BookConstants.BookState State
        {
            get;
        }

        string Author
        {
            get;
        }

        string Title
        {
            get;
        }

        string CallNumber
        {
            get;
        }

        int ID
        {
            get;
        }

    }
}
