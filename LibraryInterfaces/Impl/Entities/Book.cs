﻿using System;

using Library.Interfaces.Entities;

namespace Library.Impl.Entities
{
    public class Book : IBook
    {
        public Book(string author, string title, string callNumber, int bookID)
        {
            if (!sane(author, title, callNumber, bookID))
            {
                throw new ArgumentException("Member: constructor : bad parameters");
            }
            this.author = author;
            this.title = title;
            this.callNumber = callNumber;
            this.id = bookID;
            this.state = BookConstants.BookState.AVAILABLE;
            this.loan = null;
        }

        private bool sane(string author, string title, string callNumber, int bookID)
        {
            return (!string.IsNullOrEmpty(author) &&
                      !string.IsNullOrEmpty(title) &&
                      !string.IsNullOrEmpty(callNumber) &&
                      bookID > 0
                    );
        }


        public void Borrow(ILoan loan)
        {
            if (loan == null)
            {
                throw new ArgumentException("Book: borrow : Bad parameter: loan cannot be null");
            }
            if (!(state == BookConstants.BookState.AVAILABLE))
            {
                string mesg = String.Format("Illegal operation in state : {0}", state);
                throw new ApplicationException(mesg);
            }
            this.loan = loan;
            state = BookConstants.BookState.ON_LOAN;

        }
        private ILoan loan;
        public ILoan Loan
        {
            get { return loan; }
        }



        public void ReturnBook(bool damaged)
        {
            if (!(state == BookConstants.BookState.ON_LOAN || state == BookConstants.BookState.LOST))
            {
                throw new ApplicationException(String.Format("Illegal operation in state : {0}", state));
            }
            loan = null;
            if (damaged)
            {
                state = BookConstants.BookState.DAMAGED;
            }
            else
            {
                state = BookConstants.BookState.AVAILABLE;
            }
        }



        public void Lose()
        {
            if (!(state == BookConstants.BookState.ON_LOAN))
            {
                throw new ApplicationException(String.Format("Illegal operation in state : {0}", state));
            }
            state = BookConstants.BookState.LOST;
        }

        public void Repair()
        {
            if (!(state == BookConstants.BookState.DAMAGED))
            {
                throw new ApplicationException(String.Format("Illegal operation in state : {0}", state));
            }
            state = BookConstants.BookState.AVAILABLE;
        }

        public void Dispose()
        {
            if (!(state == BookConstants.BookState.AVAILABLE || 
                  state == BookConstants.BookState.DAMAGED || 
                  state == BookConstants.BookState.LOST))
            {
                throw new ApplicationException(String.Format("Illegal operation in state : {0}", state));
            }
            state = BookConstants.BookState.DISPOSED;
        }

        private BookConstants.BookState state;
        public BookConstants.BookState State
        {
            get { return state;  }
        }

        private string author;
        public string Author
        {
            get { return author; }
        }

        private string title;
        public string Title
        {
            get { return title; }
        }

        private string callNumber;
        public string CallNumber
        {
            get { return callNumber; }
        }

        private int id;
        public int ID
        {
            get { return id; }
        }

        public override string ToString() 
        {
            string cr = Environment.NewLine;
		    return String.Format("{1,-20}\t{2} {0}{3,-20}\t{4} {0}{5,-20}\t{6} {0}{7,-20}\t{8}",
				                  cr, 
                                  "Id:          ",id, 
                                  "Call Number: ",callNumber, 
                                  "Author:      ",author, 
                                  "Title:       ",title );

        }
    }
}
