using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (ILoan loan in loanList)
            {
                bld.Append(loan.ToString()).Append("\n\n");
            }
            currentLoan_TB.Text = bld.ToString();
            currentLoan_TB.Select(0, 0);
        }

        private void reject_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
            owner.Reject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            owner.Accept();
        }
    }
}
