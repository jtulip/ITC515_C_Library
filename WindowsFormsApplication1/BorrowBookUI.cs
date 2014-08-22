using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using Library.Interfaces.Uis;
using System.Windows.Forms;

using Library.Interfaces.Controls;
using Library.Interfaces.Entities;

namespace Library
{
    public partial class BorrowBookUI : Form, IBorrowUI
    {
        private IBorrowCTL control;
        private List<ILoan> completedList;


        public BorrowBookUI()
        {
            InitializeComponent();
        }


        public void Initialise(IBorrowCTL control)
        {
            this.control = control;

            memberID_TB.ReadOnly = true;
            swipe_BTN.Enabled = true;
            
            bookID_TB.ReadOnly = true;
            scan_BTN.Enabled = false;
            continue_BTN.Enabled = false;
            complete_BTN.Enabled = false;

            cancel_BTN.Enabled = true;

            name_LBL.Text = "";
            contact_LBL.Text = "";
            errMesg_LBL.Text = "";
            overdue_LBL.Text = "";
            fineLimit_LBL.Text = "";
            loanLimit_LBL.Text = "";

            pendingList_TB.ReadOnly = true;
            currentBook_TB.ReadOnly = true;
            existingLoan_TB.ReadOnly = true;
        }


        public void SetState(BorrowCTLConstants.State state)
        {
            switch (state)
            {
                case BorrowCTLConstants.State.STARTED:
                    memberID_TB.ReadOnly = false;
                    swipe_BTN.Enabled = true;
                    cancel_BTN.Enabled = true;
                    break;
                case BorrowCTLConstants.State.BORROWING:
                    memberID_TB.ReadOnly = true;
                    swipe_BTN.Enabled = false;
                    bookID_TB.ReadOnly = false;
                    scan_BTN.Enabled = true;
                    currentBook_TB.Text = "";
                    pendingList_TB.Text = "";

                    break;
                case BorrowCTLConstants.State.DISALLOWED:
                    memberID_TB.ReadOnly = true;
                    swipe_BTN.Enabled = false;
                    break;
                case BorrowCTLConstants.State.COMPLETED:
                    bookID_TB.Text = "";
                    bookID_TB.ReadOnly = true;
                    continue_BTN.Enabled = false;
                    complete_BTN.Enabled = false;
                    break;
                case BorrowCTLConstants.State.CONFIRMED:
                    cancel_BTN.Enabled = false;
                    continue_BTN.Enabled = false;
                    complete_BTN.Enabled = false;
                    break;
                case BorrowCTLConstants.State.CANCELLED:
                    break;
                case BorrowCTLConstants.State.ENDED:
                    this.Close();
                    break;
                default:
                    //this.Close();
                    break;
            }
        }


        public void DisplayBorrowerDetails(IMember borrower)
        {
            string name = borrower.FirstName + " " + borrower.LastName;
            string contact = borrower.ContactPhone;

            name_LBL.Text = name;
            contact_LBL.Text = contact;

            if (borrower.HasOverDueLoans)
            {
                overdue_LBL.Text = String.Format("Borrower has overdue loans.");
            }
            if (borrower.HasReachedFineLimit)
            {
                fineLimit_LBL.Text = String.Format("Borrower has reached fine limit. Amount owing: ${0:0.00}.", borrower.FineAmount);
            }
            if (borrower.HasReachedLoanLimit)
            {
                loanLimit_LBL.Text = String.Format("Borrower has reached maximum number of borrowed items permitted.");
            }
            string cr = Environment.NewLine;
            StringBuilder bld = new StringBuilder();
            foreach (ILoan loan in borrower.Loans)
            {
                bld.Append(loan.ToString()).Append(cr).Append(cr);
            }
            existingLoan_TB.Text = bld.ToString();
            existingLoan_TB.Select(0, 0);
        }


        public void ScanBook()
        {
            bookID_TB.ReadOnly = false;
            bookID_TB.Focus();
            scan_BTN.Enabled = true;
            continue_BTN.Enabled = false;
            complete_BTN.Enabled = false;
        }


        public void DisplayBook(IBook book)
        {
            currentBook_TB.Text = book.ToString();
            currentBook_TB.Select(0, 0);
        }


        public void DisplayPendingList(List<ILoan> pendingList)
        {
            string cr = Environment.NewLine;
            StringBuilder bld = new StringBuilder();
            foreach (ILoan loan in pendingList)
            {
                bld.Append(loan.ToString()).Append(cr).Append(cr);
            }
            pendingList_TB.Text = bld.ToString();
            pendingList_TB.Select(0, 0);
        }


        public void DisplayCompletedList(List<ILoan> completedList)
        {
            this.completedList = completedList;
            Form dlg = new ConfirmCompleteDialog(this, completedList);
            dlg.ShowDialog();
        }


        public void PrintLoanSlip()
        {
            Form dlg = new PrintLoanSlipDialog(this, completedList);
            dlg.ShowDialog();
            control.BorrowUcEnded();
        }


        public void Reject()
        {
            completedList = null;
            control.RejectPendingList();
        }


        public void Accept()
        {
            control.ConfirmPendingList();
        }


        private void swipe_BTN_Click(object sender, EventArgs e)
        {
            int borrowerID = 0;

            errMesg_LBL.Text = "";
            string borrowerIDstr = memberID_TB.Text;

            if (String.IsNullOrWhiteSpace(borrowerIDstr))
            {
                errMesg_LBL.Text = "Borrower ID cannot be empty or blank.";
            }
            else {
                try {
                    borrowerID = Convert.ToInt32(borrowerIDstr);
                    if (borrowerID <= 0) throw new FormatException();

                    control.CardScanned(borrowerID);

                }
                catch (FormatException) {
                    errMesg_LBL.Text = "Borrower ID must be a positive integer.";
                }
                catch (OverflowException) {
                    errMesg_LBL.Text = "Borrower ID cannot be so big.";
                }
                catch (ApplicationException)
                {
                    errMesg_LBL.Text = String.Format("Borrower ID {0}: not found.", borrowerID);
                    memberID_TB.Text = "";
                }
            }
        }


        private void cancel_BTN_Click(object sender, EventArgs e)
        {
            control.Cancel();
        }


        private void scan_BTN_Click(object sender, EventArgs e)
        {
            int bookID = 0;
            errMesg_LBL.Text = "";
            string bookIDstr = bookID_TB.Text.Trim();

            if (String.IsNullOrWhiteSpace(bookIDstr))
            {
                errMesg_LBL.Text = "Book ID cannot be empty or blank.";
            }
            else
            {
                try
                {
                    bookID = Convert.ToInt32(bookIDstr);
                    if (bookID <= 0) throw new FormatException();

                    control.BookScanned(bookID);
                    scan_BTN.Enabled = false;
                    continue_BTN.Enabled = true;
                    complete_BTN.Enabled = true;
                    bookID_TB.ReadOnly = true;
                }

                catch (FormatException)
                {
                    errMesg_LBL.Text = "Book ID must be a positive integer.";
                    bookID_TB.Text = "";
                }

                catch (OverflowException)
                {
                    errMesg_LBL.Text = "Book ID cannot be so big.";
                    bookID_TB.Text = "";
                }

                catch (ApplicationException)
                {
                    errMesg_LBL.Text = String.Format("Book ID {0}: not found.",bookID);
                    bookID_TB.Text = "";
                }
            }

        }


        private void continue_BTN_Click(object sender, EventArgs e)
        {
            bookID_TB.Text = "";
            control.ScanNext();
        }


        private void complete_BTN_Click(object sender, EventArgs e)
        {
            control.ScansCompleted();
        }


    }
}
