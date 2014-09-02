using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Library.Interfaces.Entities;

namespace Library
{
    public partial class PrintLoanSlipDialog : Form
    {
        BorrowBookUI owner;
        List<ILoan> loanList;

        public PrintLoanSlipDialog(BorrowBookUI owner, List<ILoan> loanList)
        {
            this.owner = owner;
            this.loanList = loanList;

            InitializeComponent();

            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            string cr = Environment.NewLine;
            IMember mem = loanList[0].Borrower;
            StringBuilder bld = new StringBuilder();
            bld.Append(mem.ToString()).Append(cr).Append(cr);

            foreach (ILoan loan in loanList)
            {
                bld.Append(loan.ToString()).Append(cr).Append(cr);
            }
            loanSlip_TB.Text = bld.ToString();
            loanSlip_TB.Select(0, 0);
            loanSlip_TB.ReadOnly = true;
        }

        private void ok_BTN_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
