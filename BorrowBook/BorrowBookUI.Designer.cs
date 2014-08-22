namespace Library
{
    partial class BorrowBookUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.swipe_BTN = new System.Windows.Forms.Button();
            this.memberID_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scan_BTN = new System.Windows.Forms.Button();
            this.bookID_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_BTN = new System.Windows.Forms.Button();
            this.continue_BTN = new System.Windows.Forms.Button();
            this.complete_BTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.existingLoan_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loanLimit_LBL = new System.Windows.Forms.Label();
            this.fineLimit_LBL = new System.Windows.Forms.Label();
            this.overdue_LBL = new System.Windows.Forms.Label();
            this.contact_LBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_LBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errMesg_LBL = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pendingList_TB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.currentBook_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.swipe_BTN);
            this.panel1.Controls.Add(this.memberID_TB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 132);
            this.panel1.TabIndex = 0;
            // 
            // swipe_BTN
            // 
            this.swipe_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swipe_BTN.Location = new System.Drawing.Point(69, 87);
            this.swipe_BTN.Name = "swipe_BTN";
            this.swipe_BTN.Size = new System.Drawing.Size(98, 28);
            this.swipe_BTN.TabIndex = 2;
            this.swipe_BTN.Text = "Swipe";
            this.swipe_BTN.UseVisualStyleBackColor = true;
            this.swipe_BTN.Click += new System.EventHandler(this.swipe_BTN_Click);
            // 
            // memberID_TB
            // 
            this.memberID_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberID_TB.Location = new System.Drawing.Point(11, 44);
            this.memberID_TB.Name = "memberID_TB";
            this.memberID_TB.Size = new System.Drawing.Size(222, 26);
            this.memberID_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Swipe Member Card";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.scan_BTN);
            this.panel2.Controls.Add(this.bookID_TB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(366, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 132);
            this.panel2.TabIndex = 1;
            // 
            // scan_BTN
            // 
            this.scan_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_BTN.Location = new System.Drawing.Point(86, 87);
            this.scan_BTN.Name = "scan_BTN";
            this.scan_BTN.Size = new System.Drawing.Size(93, 28);
            this.scan_BTN.TabIndex = 2;
            this.scan_BTN.Text = "Scan";
            this.scan_BTN.UseVisualStyleBackColor = true;
            this.scan_BTN.Click += new System.EventHandler(this.scan_BTN_Click);
            // 
            // bookID_TB
            // 
            this.bookID_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookID_TB.Location = new System.Drawing.Point(11, 44);
            this.bookID_TB.Name = "bookID_TB";
            this.bookID_TB.Size = new System.Drawing.Size(232, 26);
            this.bookID_TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scan Book";
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_BTN.Location = new System.Drawing.Point(13, 162);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.Size = new System.Drawing.Size(91, 28);
            this.cancel_BTN.TabIndex = 2;
            this.cancel_BTN.Text = "Cancel";
            this.cancel_BTN.UseVisualStyleBackColor = true;
            this.cancel_BTN.Click += new System.EventHandler(this.cancel_BTN_Click);
            // 
            // continue_BTN
            // 
            this.continue_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_BTN.Location = new System.Drawing.Point(366, 162);
            this.continue_BTN.Name = "continue_BTN";
            this.continue_BTN.Size = new System.Drawing.Size(105, 28);
            this.continue_BTN.TabIndex = 3;
            this.continue_BTN.Text = "Continue";
            this.continue_BTN.UseVisualStyleBackColor = true;
            this.continue_BTN.Click += new System.EventHandler(this.continue_BTN_Click);
            // 
            // complete_BTN
            // 
            this.complete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete_BTN.Location = new System.Drawing.Point(524, 162);
            this.complete_BTN.Name = "complete_BTN";
            this.complete_BTN.Size = new System.Drawing.Size(100, 28);
            this.complete_BTN.TabIndex = 4;
            this.complete_BTN.Text = "Complete";
            this.complete_BTN.UseVisualStyleBackColor = true;
            this.complete_BTN.Click += new System.EventHandler(this.complete_BTN_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.contact_LBL);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.name_LBL);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 301);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.existingLoan_TB);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(12, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(586, 167);
            this.panel5.TabIndex = 6;
            // 
            // existingLoan_TB
            // 
            this.existingLoan_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.existingLoan_TB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingLoan_TB.Location = new System.Drawing.Point(12, 30);
            this.existingLoan_TB.Multiline = true;
            this.existingLoan_TB.Name = "existingLoan_TB";
            this.existingLoan_TB.ReadOnly = true;
            this.existingLoan_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.existingLoan_TB.Size = new System.Drawing.Size(558, 122);
            this.existingLoan_TB.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Existing loans";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.loanLimit_LBL);
            this.panel4.Controls.Add(this.fineLimit_LBL);
            this.panel4.Controls.Add(this.overdue_LBL);
            this.panel4.Location = new System.Drawing.Point(12, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 54);
            this.panel4.TabIndex = 5;
            // 
            // loanLimit_LBL
            // 
            this.loanLimit_LBL.AutoSize = true;
            this.loanLimit_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanLimit_LBL.ForeColor = System.Drawing.Color.Red;
            this.loanLimit_LBL.Location = new System.Drawing.Point(3, 32);
            this.loanLimit_LBL.Name = "loanLimit_LBL";
            this.loanLimit_LBL.Size = new System.Drawing.Size(124, 16);
            this.loanLimit_LBL.TabIndex = 2;
            this.loanLimit_LBL.Text = "Loan limit restriction";
            // 
            // fineLimit_LBL
            // 
            this.fineLimit_LBL.AutoSize = true;
            this.fineLimit_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineLimit_LBL.ForeColor = System.Drawing.Color.Red;
            this.fineLimit_LBL.Location = new System.Drawing.Point(3, 16);
            this.fineLimit_LBL.Name = "fineLimit_LBL";
            this.fineLimit_LBL.Size = new System.Drawing.Size(120, 16);
            this.fineLimit_LBL.TabIndex = 1;
            this.fineLimit_LBL.Text = "Fine limit restriction";
            // 
            // overdue_LBL
            // 
            this.overdue_LBL.AutoSize = true;
            this.overdue_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdue_LBL.ForeColor = System.Drawing.Color.Red;
            this.overdue_LBL.Location = new System.Drawing.Point(3, 0);
            this.overdue_LBL.Name = "overdue_LBL";
            this.overdue_LBL.Size = new System.Drawing.Size(120, 16);
            this.overdue_LBL.TabIndex = 0;
            this.overdue_LBL.Text = "Overdue restriction";
            // 
            // contact_LBL
            // 
            this.contact_LBL.AutoSize = true;
            this.contact_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_LBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.contact_LBL.Location = new System.Drawing.Point(384, 27);
            this.contact_LBL.Name = "contact_LBL";
            this.contact_LBL.Size = new System.Drawing.Size(98, 20);
            this.contact_LBL.TabIndex = 4;
            this.contact_LBL.Text = "02 555 6375";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contact: ";
            // 
            // name_LBL
            // 
            this.name_LBL.AutoSize = true;
            this.name_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_LBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.name_LBL.Location = new System.Drawing.Point(77, 27);
            this.name_LBL.Name = "name_LBL";
            this.name_LBL.Size = new System.Drawing.Size(88, 20);
            this.name_LBL.TabIndex = 2;
            this.name_LBL.Text = "Fred Nurke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Borrower Details";
            // 
            // errMesg_LBL
            // 
            this.errMesg_LBL.AutoSize = true;
            this.errMesg_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMesg_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errMesg_LBL.Location = new System.Drawing.Point(9, 970);
            this.errMesg_LBL.Name = "errMesg_LBL";
            this.errMesg_LBL.Size = new System.Drawing.Size(135, 20);
            this.errMesg_LBL.TabIndex = 6;
            this.errMesg_LBL.Text = "Error Messages";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(12, 525);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 433);
            this.panel6.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.pendingList_TB);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(12, 180);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(584, 241);
            this.panel8.TabIndex = 2;
            // 
            // pendingList_TB
            // 
            this.pendingList_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pendingList_TB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingList_TB.Location = new System.Drawing.Point(11, 31);
            this.pendingList_TB.Multiline = true;
            this.pendingList_TB.Name = "pendingList_TB";
            this.pendingList_TB.ReadOnly = true;
            this.pendingList_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pendingList_TB.Size = new System.Drawing.Size(559, 192);
            this.pendingList_TB.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Pending Loan List";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.currentBook_TB);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(12, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(585, 140);
            this.panel7.TabIndex = 1;
            // 
            // currentBook_TB
            // 
            this.currentBook_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currentBook_TB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBook_TB.Location = new System.Drawing.Point(11, 27);
            this.currentBook_TB.Multiline = true;
            this.currentBook_TB.Name = "currentBook_TB";
            this.currentBook_TB.ReadOnly = true;
            this.currentBook_TB.Size = new System.Drawing.Size(559, 102);
            this.currentBook_TB.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Current Book";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Current Loan";
            // 
            // BorrowBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 1005);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.errMesg_LBL);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.complete_BTN);
            this.Controls.Add(this.continue_BTN);
            this.Controls.Add(this.cancel_BTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BorrowBookUI";
            this.Text = "Borrow Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button swipe_BTN;
        private System.Windows.Forms.TextBox memberID_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button scan_BTN;
        private System.Windows.Forms.TextBox bookID_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_BTN;
        private System.Windows.Forms.Button continue_BTN;
        private System.Windows.Forms.Button complete_BTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox existingLoan_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label loanLimit_LBL;
        private System.Windows.Forms.Label fineLimit_LBL;
        private System.Windows.Forms.Label overdue_LBL;
        private System.Windows.Forms.Label contact_LBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label name_LBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errMesg_LBL;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox pendingList_TB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox currentBook_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

