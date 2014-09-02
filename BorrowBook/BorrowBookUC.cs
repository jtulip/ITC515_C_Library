using System;
using System.Windows.Forms;

using Library.Interfaces.Uis;
using Library.Interfaces.Controls;
using Library.Interfaces.Daos;
using Library.Interfaces.Entities;

using Library.Impl.Daos;

using Library.Impl.Controls;
using Library.Impl.Helpers;

namespace Library
{
    static class BorrowBookUC
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //setup
            IMemberDAO memberDAO = new MemberDAO(new MemberHelper());
            IBookDAO bookDAO = new BookDAO(new BookHelper());
            ILoanDAO loanDAO = new LoanDAO(new LoanHelper());

            IMember mem = memberDAO.AddMember("John", "Smith", "jsmith@gmail.com", "02 622 94753");

            IBook book1 = bookDAO.AddBook("Robert Heinlein", "Space Cadet", "HEI 3.645");
            IBook book2 = bookDAO.AddBook("Charles Stross", "The Laundry Files", "STR 7.593");
            IBook book3 = bookDAO.AddBook("James Cambias", "A Darkling Sea", "CAM 5.657");
            IBook book4 = bookDAO.AddBook("John Steinbeck", "Cannery Row", "STE 9.531");
            IBook book5 = bookDAO.AddBook("Terry Pratchett", "Raising Steam", "PRA 1.739");
            IBook book6 = bookDAO.AddBook("Vernor Vinge", "Fire Upon the Deep", "VIN 8.927");
/*
            IBook b = bookDAO.GetBookByID(1);
            b = bookDAO.GetBookByID(2);
            b = bookDAO.GetBookByID(3);
            b = bookDAO.GetBookByID(4);

            DateTime borrowDate = DateTime.Now;
            TimeSpan loanPeriod = new TimeSpan(LoanConstants.LOAN_PERIOD, 0, 0, 0);
            DateTime dueDate = borrowDate.Add(loanPeriod);

            loanDAO.CreateNewPendingList(mem);
            loanDAO.CreatePendingLoan(mem, book1, borrowDate, dueDate);
            loanDAO.CreatePendingLoan(mem, book2, borrowDate, dueDate);
            loanDAO.CreatePendingLoan(mem, book3, borrowDate, dueDate);
            loanDAO.CreatePendingLoan(mem, book4, borrowDate, dueDate);
            loanDAO.CreatePendingLoan(mem, book5, borrowDate, dueDate);
            loanDAO.CommitPendingLoans(mem);

            DateTime checkDate = dueDate.Add(new TimeSpan(1, 0, 0, 0));
            loanDAO.UpdateOverDueStatus(checkDate);

            mem.AddFine(10.00f);
*/
            BorrowBookUI gui = new BorrowBookUI();
            BorrowBookCTL ctl = new BorrowBookCTL(bookDAO, memberDAO,loanDAO, gui);

            ctl.Initialise();
            Application.Run(gui);
        }
    }
}
