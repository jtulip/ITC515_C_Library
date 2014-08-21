namespace Library
{
    partial class ConfirmCompleteDialog
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
            this.currentLoan_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reject_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.currentLoan_TB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 268);
            this.panel1.TabIndex = 0;
            // 
            // currentLoan_TB
            // 
            this.currentLoan_TB.BackColor = System.Drawing.Color.White;
            this.currentLoan_TB.Location = new System.Drawing.Point(7, 30);
            this.currentLoan_TB.Multiline = true;
            this.currentLoan_TB.Name = "currentLoan_TB";
            this.currentLoan_TB.ReadOnly = true;
            this.currentLoan_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentLoan_TB.Size = new System.Drawing.Size(498, 225);
            this.currentLoan_TB.TabIndex = 1;
            this.currentLoan_TB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Loan List";
            // 
            // reject_BTN
            // 
            this.reject_BTN.AutoEllipsis = true;
            this.reject_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject_BTN.Location = new System.Drawing.Point(85, 296);
            this.reject_BTN.Name = "reject_BTN";
            this.reject_BTN.Size = new System.Drawing.Size(104, 30);
            this.reject_BTN.TabIndex = 1;
            this.reject_BTN.Text = "Reject";
            this.reject_BTN.UseVisualStyleBackColor = true;
            this.reject_BTN.Click += new System.EventHandler(this.reject_BTN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfirmCompleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reject_BTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfirmCompleteDialog";
            this.Text = "ConfirmCompleteDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox currentLoan_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reject_BTN;
        private System.Windows.Forms.Button button1;
    }
}