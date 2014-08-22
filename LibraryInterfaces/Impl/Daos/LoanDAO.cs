﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Daos;
using Library.Interfaces.Entities;
using Library.Interfaces.Helpers; 

namespace Library.Impl.Daos 
{
    public class LoanDAO : ILoanDAO
    {
        private ILoanHelper helper;
        private Dictionary<int, ILoan> loanDict;
        private Dictionary<IMember, List<ILoan>> pendDict;
        private int nextID;


        public LoanDAO(ILoanHelper helper)
        {
		    if (helper == null ) {
			    throw new ArgumentException(
                    String.Format("LoanDAO : constructor : helper cannot be null."));
		    }
		    this.helper = helper;
            this.loanDict = new Dictionary<int, ILoan>();
            this.pendDict = new Dictionary<IMember, List<ILoan>>();
            this.nextID = 1;
	    }


        public void CreateNewPendingList(IMember borrower)
        {
            if (borrower == null)
            {
                throw new ArgumentException(
                    String.Format("LoanDAO : createNewPendingList : borrower cannot be null."));
            }
            List<ILoan> pendList = new List<ILoan>();
            pendDict.Add(borrower, pendList);

        }


        public ILoan CreatePendingLoan(IMember borrower, IBook book, DateTime borrowDate, DateTime dueDate)
        {
		    if (borrower == null || book == null || borrowDate == null || dueDate == null ) {
			    throw new ArgumentException(
				    String.Format("LoanMapDAO : CreatePendingLoan : parameters cannot be null."));
		    }
		    if (DateTime.Compare(borrowDate, dueDate) > 0) {
			    throw new ArgumentException(
				    String.Format("LoanDAO : createPendingLoan : borrowDate cannot be after dueDate."));
		    }
		    int id = NextID;
		    ILoan loan = helper.MakeLoan(book, borrower, borrowDate, dueDate, id);
		    if (!pendDict.ContainsKey(borrower)) {
			    throw new ApplicationException("LoanMapDAO : createPendingLoan : no pending list for member found");
		    }
		    List<ILoan> pendList = pendDict[borrower];
		    pendList.Add(loan);
		    return loan;
        }


        public List<ILoan> GetPendingList(IMember borrower)
        {
            if (borrower == null)
            {
                throw new ArgumentException(
                    String.Format("LoanMapDAO : getPendingList : borrower cannot be null."));
            }
            List<ILoan> pendList = pendDict[borrower];
            return pendList;
        }


        public void CommitPendingLoans(IMember borrower)
        {
		    if (borrower == null ) {
			    throw new ArgumentException(
				    String.Format("LoanMapDAO : commitPendingLoans : borrower cannot be null."));
		    }
		    if (!pendDict.ContainsKey(borrower)) {
			    throw new ApplicationException("LoanDAO : commitPendingLoans : no pending list for member found");
		    }
		    List<ILoan> pendingList = pendDict[borrower];
		    foreach (ILoan loan in pendingList) {
			    borrower.AddLoan(loan);
			    IBook book = loan.Book;
			    book.Borrow(loan);
			    loan.Commit();
			    int id = loan.ID;
			    loanDict.Add(id, loan);
		    }
		    pendDict.Remove(borrower);
        }


        public void ClearPendingLoans(IMember borrower)
        {
            if (borrower == null)
            {
                throw new ArgumentException(
                    String.Format("LoanMapDAO : clearPendingLoans : borrower cannot be null."));
            }
            if (!pendDict.ContainsKey(borrower))
            {
                throw new ApplicationException("LoanDAO : clearPendingLoans : no pending list for member found");
            }
            pendDict.Remove(borrower);

        }


        public ILoan GetLoanByID(int id)
        {
            if (loanDict.ContainsKey(id))
            {
                return loanDict[id];
            }
            return null;
        }


        public ILoan GetLoanByBook(IBook book)
        {
		    if (book == null ) {
			    throw new ArgumentException(
				    String.Format("LoanMapDAO : getLoanByBook : book cannot be null."));
		    }
		    foreach (ILoan loan in loanDict.Values) {
			    IBook tempBook = loan.Book;
			    if (book.Equals(tempBook)) {
				    return loan;
			    }
		    }
		    return null;
        }

        public List<ILoan> LoanList
        {
            get
            {
                List<ILoan> list = new List<ILoan>();
                Dictionary<int, ILoan>.ValueCollection tloan = loanDict.Values;
                foreach (ILoan b in tloan)
                {
                    list.Add(b);
                }
                return list;
            }
        }

        public List<ILoan> FindLoansByBorrower(IMember borrower)
        {
            List<ILoan> list = new List<ILoan>();
            Dictionary<int, ILoan>.ValueCollection tloan = loanDict.Values;
            foreach (ILoan b in tloan)
            {
                if (b.Borrower.Equals(borrower))
                {
                    list.Add(b);
                }
            }
            return list;
        }

        public List<ILoan> FindLoansByBookTitle(string title)
        {
            List<ILoan> list = new List<ILoan>();
            Dictionary<int, ILoan>.ValueCollection tloan = loanDict.Values;
            foreach (ILoan b in tloan)
            {
                if (b.Book.Title.Equals(title))
                {
                    list.Add(b);
                }
            }
            return list;
        }

        public void UpdateOverDueStatus(DateTime currentDate)
        {
            Dictionary<int, ILoan>.ValueCollection tloan = loanDict.Values;
            foreach (ILoan loan in tloan)
            {
                loan.CheckOverDue(currentDate);
            }
        }


        public List<ILoan> FindOverDueLoans()
        {
		    List<ILoan> list = new List<ILoan>();
            Dictionary<int, ILoan>.ValueCollection tloan = loanDict.Values;
		    foreach (ILoan loan in tloan) {
			    if (loan.IsOverDue) {
				    list.Add(loan);
			    }
		    }
            return list;
        }

        private int NextID
        {
            get { return nextID++; }
        }

    }
}
