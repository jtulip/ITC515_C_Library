using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
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

        public BorrowBookUI()
        {
            InitializeComponent();
        }
        public void initialise(IBorrowCTL control)
        {
            this.control = control;

            swipe_BTN.Enabled = true;
            scan_BTN.Enabled = false;
            continue_BTN.Enabled = false;
            complete_BTN.Enabled = false;
            cancel_BTN.Enabled = true;
            memberID_TB.ReadOnly = true;
            bookID_TB.ReadOnly = true;

            name_LBL.Text = "";
            contact_LBL.Text = "";
            errMesg_LBL.Text = "";
            overdue_LBL.Text = "";
            fineLimit_LBL.Text = "";
            loanLimit_LBL.Text = "";
        }

        public void setState(BorrowCTLConstants.State state)
        {

        }

        public void displayBorrowerDetails(IMember borrower)
        {

        }

        public void scanBook()
        {

        }

        public void displayBook(IBook book)
        {

        }

        public void displayPendingList(List<ILoan> pendingList)
        {

        }

        public void displayCompletedList(List<ILoan> pendingList)
        {

        }

        public void printLoanSlip()
        {

        }

        private void swipe_BTN_Click(object sender, EventArgs e)
        {

        }

        private void cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scan_BTN_Click(object sender, EventArgs e)
        {

        }

        private void continue_BTN_Click(object sender, EventArgs e)
        {

        }

        private void complete_BTN_Click(object sender, EventArgs e)
        {

        }


    }
}
