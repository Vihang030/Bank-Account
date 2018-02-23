namespace BankAccount
{
    partial class FrmTestAccounts
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
            this.btnSavingsAccount = new System.Windows.Forms.Button();
            this.btnChequingAccount = new System.Windows.Forms.Button();
            this.btnPremiumAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSavingsAccount
            // 
            this.btnSavingsAccount.Location = new System.Drawing.Point(37, 12);
            this.btnSavingsAccount.Name = "btnSavingsAccount";
            this.btnSavingsAccount.Size = new System.Drawing.Size(166, 38);
            this.btnSavingsAccount.TabIndex = 0;
            this.btnSavingsAccount.Text = "Test Savings Account";
            this.btnSavingsAccount.UseVisualStyleBackColor = true;
            this.btnSavingsAccount.Click += new System.EventHandler(this.btnSavingsAccount_Click);
            // 
            // btnChequingAccount
            // 
            this.btnChequingAccount.Location = new System.Drawing.Point(37, 56);
            this.btnChequingAccount.Name = "btnChequingAccount";
            this.btnChequingAccount.Size = new System.Drawing.Size(166, 38);
            this.btnChequingAccount.TabIndex = 1;
            this.btnChequingAccount.Text = "Test Chequing Account";
            this.btnChequingAccount.UseVisualStyleBackColor = true;
            this.btnChequingAccount.Click += new System.EventHandler(this.btnChequingAccount_Click);
            // 
            // btnPremiumAccount
            // 
            this.btnPremiumAccount.Location = new System.Drawing.Point(37, 100);
            this.btnPremiumAccount.Name = "btnPremiumAccount";
            this.btnPremiumAccount.Size = new System.Drawing.Size(166, 38);
            this.btnPremiumAccount.TabIndex = 2;
            this.btnPremiumAccount.Text = "Test Premium Account";
            this.btnPremiumAccount.UseVisualStyleBackColor = true;
            this.btnPremiumAccount.Click += new System.EventHandler(this.btnPremiumAccount_Click);
            // 
            // FrmTestAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 153);
            this.Controls.Add(this.btnPremiumAccount);
            this.Controls.Add(this.btnChequingAccount);
            this.Controls.Add(this.btnSavingsAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTestAccounts";
            this.Text = "Test Bank Accounts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSavingsAccount;
        private System.Windows.Forms.Button btnChequingAccount;
        private System.Windows.Forms.Button btnPremiumAccount;
    }
}

