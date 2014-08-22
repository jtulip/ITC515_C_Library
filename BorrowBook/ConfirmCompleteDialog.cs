using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Library.Interfaces.Entities;

namespace Library
{
    public partial class ConfirmCompleteDialog : Form
    {
        BorrowBookUI owner;
        List<ILoan> loanList;

        public ConfirmCompleteDialog( BorrowBookUI owner, List<ILoan> loanList)
        {
            this.owner = owner;
            this.loanList = loanList;

            InitializeComponent();

            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            StringBuilder bld = new StringBuilder();
            string cr = Environment.NewLine;
            foreach (ILoan loan in loanList)
            {
                bld.Append(loan.ToString()).Append(cr).Append(cr);
            }
            currentLoan_TB.Text = bld.ToString();
            currentLoan_TB.Select(0, 0);
        }

        private void reject_BTN_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            owner.Reject();
        }

        private void accept_BTN_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            owner.Accept();
        }

    }
}
