namespace Library
{
    partial class PrintLoanSlipDialog
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
            this.loanSlip_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loanSlip_TB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 270);
            this.panel1.TabIndex = 0;
            // 
            // loanSlip_TB
            // 
            this.loanSlip_TB.BackColor = System.Drawing.Color.White;
            this.loanSlip_TB.Location = new System.Drawing.Point(11, 30);
            this.loanSlip_TB.Multiline = true;
            this.loanSlip_TB.Name = "loanSlip_TB";
            this.loanSlip_TB.ReadOnly = true;
            this.loanSlip_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loanSlip_TB.Size = new System.Drawing.Size(531, 227);
            this.loanSlip_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Slip";
            // 
            // ok_BTN
            // 
            this.ok_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_BTN.Location = new System.Drawing.Point(242, 296);
            this.ok_BTN.Name = "ok_BTN";
            this.ok_BTN.Size = new System.Drawing.Size(95, 31);
            this.ok_BTN.TabIndex = 1;
            this.ok_BTN.Text = "OK";
            this.ok_BTN.UseVisualStyleBackColor = true;
            this.ok_BTN.Click += new System.EventHandler(this.ok_BTN_Click);
            // 
            // PrintLoanSlipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 339);
            this.Controls.Add(this.ok_BTN);
            this.Controls.Add(this.panel1);
            this.Name = "PrintLoanSlipDialog";
            this.Text = "PrintLoanSlipDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox loanSlip_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_BTN;
    }
}