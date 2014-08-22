using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Controls;
using Library.Interfaces.Entities;
using Library.Interfaces.Daos;
using Library.Interfaces.Uis;

namespace Library.Impl.Controls

{
    public class BorrowBookCTL : IBorrowCTL
    {
        private IBookDAO bookDAO;
        private IMemberDAO memberDAO;
        private ILoanDAO loanDAO;
        private IBorrowUI ui;
        private BorrowCTLConstants.State state;
        private List<IBook> bookList;

        private List<ILoan> pendingList;

        private IMember member;
        private IBook book;

        bool overdue, atLoanLimit, overFineLimit, further_borrowing_allowed;
        int existingLoanCount, pendingLoanCount;

        public BorrowBookCTL(IBookDAO bookDAO, IMemberDAO memberDAO, ILoanDAO loanDAO, IBorrowUI ui)
        {

            if (bookDAO == null || memberDAO == null || loanDAO == null || ui == null)
            {
                throw new ArgumentException(String.Format("BorrowCTL : constructor : parameters cannot be null."));
            }
            this.bookDAO = bookDAO;
            this.memberDAO = memberDAO;
            this.loanDAO = loanDAO;
            this.ui = ui;
            overdue = atLoanLimit = overFineLimit = false;
            further_borrowing_allowed = true;
            existingLoanCount = 0;
            pendingLoanCount = 0;
            bookList = new List<IBook>();
        }

        public void Initialise()
        {
            state = BorrowCTLConstants.State.STARTED;
            ui.Initialise(this);
            ui.SetState(state);
        }


        public void Cancel()
        {
            if (state != BorrowCTLConstants.State.STARTED && state != BorrowCTLConstants.State.DISALLOWED)
            {
                loanDAO.ClearPendingLoans(member);
            }
            state = BorrowCTLConstants.State.ENDED;
            ui.SetState(state);
        }


        public void CardScanned(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException(String.Format("BorrowCTL : cardScanned : memberID cannot be <= 0."));
            }
            if (state != BorrowCTLConstants.State.STARTED)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : cardScanned : illegal operation in state: {0}", state));
            }
            member = memberDAO.GetMemberByID(memberID);
            if (member == null)
            {
                throw new ApplicationException(String.Format("BorrowCTL : cardScanned : memberID not found"));
            }
            overdue = member.HasOverDueLoans;
            atLoanLimit = member.HasReachedLoanLimit;
            overFineLimit = member.HasReachedFineLimit;
            further_borrowing_allowed = !(overdue || atLoanLimit || overFineLimit);
            existingLoanCount = member.Loans.Count;

            ui.DisplayBorrowerDetails(member);
            if (further_borrowing_allowed)
            {
                state = BorrowCTLConstants.State.BORROWING;
                ui.SetState(state);
                loanDAO.CreateNewPendingList(member);
                bookList.Clear();
                ui.ScanBook();
            }
            else
            {
                state = BorrowCTLConstants.State.DISALLOWED;
                ui.SetState(state);
            }
        }


        public void BookScanned(int bookID)
        {
            if (bookID <= 0)
            {
                throw new ArgumentException(String.Format("BorrowCTL : bookScanned : bookID cannot be <= 0."));
            }
            if (state != BorrowCTLConstants.State.BORROWING)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : cardScanned : illegal operation in state: {0}", state));
            }
            book = bookDAO.GetBookByID(bookID);
            if (book == null)
            {
                throw new ApplicationException(String.Format("BorrowCTL : bookScanned : bookID not found"));
            }

            if (book.State != BookConstants.BookState.AVAILABLE)
            {
                throw new ApplicationException(String.Format("BorrowCTL : bookScanned : illegal BookState: %s", book.State));
            }
            if (bookList.Contains(book))
            {
                throw new ApplicationException(String.Format("BorrowCTL : bookScanned : book %d already scanned: ", book.ID));
            }
            DateTime borrowDate = DateTime.Now;
            TimeSpan loanPeriod = new TimeSpan(LoanConstants.LOAN_PERIOD, 0, 0, 0);
            DateTime dueDate = borrowDate.Add(loanPeriod);

            loanDAO.CreatePendingLoan(member, book, borrowDate, dueDate);
            bookList.Add(book);
            pendingLoanCount++;

            atLoanLimit = ((existingLoanCount + pendingLoanCount) >= MemberConstants.LOAN_LIMIT);
            further_borrowing_allowed = !(overdue || atLoanLimit || overFineLimit);

            ui.DisplayBook(book);
            pendingList = loanDAO.GetPendingList(member);
            ui.DisplayPendingList(pendingList);

            if (atLoanLimit)
            {
                state = BorrowCTLConstants.State.COMPLETED;
                ui.SetState(state);
                pendingList = loanDAO.GetPendingList(member);
                ui.DisplayCompletedList(pendingList);

            }
        }

        public void ScanNext()
        {
            if (state != BorrowCTLConstants.State.BORROWING)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : scanNext : illegal operation in state: {0}", state));
            }
            ui.ScanBook();
        }

        public void ScansCompleted()
        {
            if (state != BorrowCTLConstants.State.BORROWING)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : scanNext : illegal operation in state: {0}", state));
            }
            state = BorrowCTLConstants.State.COMPLETED;
            ui.SetState(state);
            pendingList = loanDAO.GetPendingList(member);
            ui.DisplayCompletedList(pendingList);
        }

        public void RejectPendingList()
        {
            if (state != BorrowCTLConstants.State.COMPLETED)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : rejectPendingList : illegal operation in state: {0}", state));
            }
            pendingList = loanDAO.GetPendingList(member);
            pendingList.Clear();
            bookList.Clear();
            pendingLoanCount = 0;
            state = BorrowCTLConstants.State.BORROWING;
            ui.SetState(state);
            ui.ScanBook();
        }

        public void ConfirmPendingList()
        {
            if (state != BorrowCTLConstants.State.COMPLETED)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : confirmPendingList : illegal operation in state: {0}", state));
            }
            loanDAO.CommitPendingLoans(member);
            bookList = null;
            state = BorrowCTLConstants.State.CONFIRMED;
            ui.SetState(state);
            ui.PrintLoanSlip();
        }

        public void BorrowUcEnded()
        {
            if (state != BorrowCTLConstants.State.CONFIRMED)
            {
                throw new ApplicationException(
                        String.Format("BorrowCTL : borrowUCended : illegal operation in state: {0}", state));
            }
            state = BorrowCTLConstants.State.ENDED;
            ui.SetState(state);
        }

    }
}
