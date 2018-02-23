using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Done by:  Cliff Patrick
// Modified By: Vihang Chaudhari
// Student Number: 4302764
namespace BankAccount
{
    public partial class FrmTestAccounts : Form
    {
        public FrmTestAccounts()
        {
            InitializeComponent();
        }

        private void btnSavingsAccount_Click(object sender, EventArgs e)
        {
            //// create account with vaild values
            //SavingsAccount b1 = new SavingsAccount(123, 100, "Savings Account", 0.05m);
            SavingAccount b1 = new SavingAccount(123, 100, "Saving Account", 0.05m);

            //// test get accessors
            //string display = "Testing Get Accessors for Savings Account: " +
            //                 "\nClient Name: " + b1.ClientName +
            //                 "\nAccount Number: " + b1.AccountNumber +
            //                 "\nDate Open: " + b1.DateOpen +
            //                 "\nBalance: " + b1.Balance +
            //                 "\nInterest: " + b1.Interest;
            string Display = "Testing Get Accessors for Savings Account: " +
                              "\nClient Name: " + b1.ClientName +
                              "\nAccount Number: " + b1.AccountNumber +
                              "\nDate Open: " + b1.DateOpen +
                              "\nBalance: " + b1.Balance +
                              "\nInterest: " + b1.Interest;

            //// test set accessors - valid data
            b1.ClientName = "J Doe";

            b1.Interest = 0.06m;
            Display += "\n\nTest Set Accessors: Name = J Doe, Interest = 0.06" +
                      "\nNew Name: " + b1.ClientName +
                      "\nNew Interest: " + b1.Interest;

            //// test set accessors - invalid data
            b1.ClientName = "";
            b1.Interest = 5;
            Display += "\n\nTest Set Accessors: Name = null, Interest = 5" +
                       "\nNew Name: " + b1.ClientName +
                       "\nNew Interest: " + b1.Interest;

            //// test ToString() method
            Display += "\n\nToString():\n" + b1.ToString();

            //// test Deposit method
            decimal deposit = b1.Deposit(20m);
            Display += "\n\nDeposit $20, Deposit: " + deposit;
            deposit = b1.Deposit(-30m);
            Display += "\nDeposit -$30, Deposit: " + deposit +
                       "\nBalance: " + b1.Balance;

            //// test Withdraw method
            decimal withdraw = b1.Withdraw(20m);
            Display += "\n\nWithdraw $20, Withdraw: " + withdraw;
            withdraw = b1.Withdraw(-30m);
            Display += "\nWithdraw -$30, Withdraw: " + withdraw +
                       "\nBalance: " + b1.Balance;

            //// test ApplyMonthlyInterest method
            Display += "\n\nBalance Before Interest: " + b1.Balance;
            decimal interest = b1.ApplyMonthlyInterest();
            Display += "\nInterest Earned: " + interest +
                       "\nNew Balance: " + b1.Balance;

            MessageBox.Show(Display, BankAccount.BankName);
        }

        private void btnChequingAccount_Click(object sender, EventArgs e)
        {
            //// create account with vaild values
            //ChequingAccount b1 = new ChequingAccount(123, 100, "Chequing Account", 5);
            ChequingAccount b1 = new ChequingAccount(123, 100M, "Chequing Account", 5M);

            //// test get accessors
         
            string Display = "Testing Get Accessors for Savings Account: \nClient Name: "
                             + b1.ClientName + "\nAccount Number: "
                            + b1.AccountNumber + "\nDate Open: " + b1.DateOpen + "\nBalance: "
                            + b1.Balance + "\nFee: " + b1.Fee;

            //// test set accessors - valid data
           
            b1.ClientName = "J Doe";
            b1.Fee = 15M;
           
            Display += "\n\nTest Set Accessors: Name = J Doe, Fee = $15\nNew Name: "
                        + b1.ClientName + "\nNew Fee: " + b1.Fee;

            //// test set accessors - invalid data
            b1.ClientName = "";
            b1.Fee = 5M;
        
            Display += "\n\nTest Set Accessors: Name = null, Fee = $5\nNew Name: " + b1.ClientName
                        + "\nNew Fee: " + b1.Fee;
            //// test ToString() method
            Display += "\n\nTostring():\n" + b1.ToString();

            //// test Deposit method
            decimal deposit = b1.Deposit(20m);     
            Display += "\n\nDeposite $20, Deposit:" + deposit;
            deposit = b1.Deposit(-30m);
            Display += "\nDepost -$30, Deposit: " + deposit +
                          "\nBalance: " + b1.Balance;

            //// test Withdraw method
            decimal withdraw = b1.Withdraw(20m);
            Display += "\n\nWithdraw $20,Withdraw: " + withdraw;
            withdraw = b1.Withdraw(-30m);
            Display += "\nWithdraw -$30, Withdraw: " + withdraw + "\nBalance: " + b1.Balance;

            //// test ApplyMonthlyFee method
            Display += "\n\nBalance Before Monthly Fee:" + b1.Balance;
            decimal monthlyFee = b1.ApplyMonthlyFee();
            Display += "\nFee Charged: " + monthlyFee +
                        "\nNew Balance: " + b1.Balance;
            MessageBox.Show(Display, BankAccount.BankName);
        }

        private void btnPremiumAccount_Click(object sender, EventArgs e)
        {
            //// create account with vaild values
            PremiumAccount b1 = new PremiumAccount(123, 100, "Premium Account", 5, 150);

            // test get accessors
            string Display = "Testing Get Accessors for Savings Account: " +
                             "\nClient Name: " + b1.ClientName +
                             "\nAccount Number: " + b1.AccountNumber +
                             "\nDate Open: " + b1.DateOpen +
                             "\nBalance: " + b1.Balance +
                             "\nFee: " + b1.Fee +
                             "\nOverdraft Amount: " + b1.OverDraft;

            //// test set accessors - valid data
            b1.ClientName = "J Doe";
            b1.Fee = 15m;
            b1.OverDraft = 200m;
            Display += "\n\nTest Set Accessors: Name = J Doe, Fee = $15, Overdraft = $200" +
                       "\nNew Name: " + b1.ClientName +
                       "\nNew Fee: " + b1.Fee +
                      "\nNew Overdraft Amount: " + b1.OverDraft;

            //// test set accessors - invalid data
            b1.ClientName = "";
            b1.Fee = 5m;
            b1.OverDraft = 50m;
            Display += "\n\nTest Set Accessors: Name = null, Fee = $5, Overdraft = $50" +
                      "\nNew Name: " + b1.ClientName +
                      "\nNew Fee: " + b1.Fee +
                      "\nNew Overdraft Amount: " + b1.OverDraft;

            //// test ToString() method
            Display += "\n\nToString():\n" + b1.ToString();

            //// test Deposit method
            decimal deposit = b1.Deposit(20m);
            Display += "\n\nDeposit $20, Deposit: " + deposit;
            deposit = b1.Deposit(-30m);
            Display += "\nDeposit -$30, Deposit: " + deposit +
                       "\nBalance: " + b1.Balance;

            //// test Withdraw method
            decimal withdraw = b1.Withdraw(20m);
            Display += "\n\nWithdraw $20, Withdraw: " + withdraw;
            withdraw = b1.Withdraw(-30m);
            Display += "\nWithdraw -$30, Withdraw: " + withdraw +
                       "\nBalance: " + b1.Balance;

            //// test ApplyMonthlyFee method
            Display += "\n\nBalance Before Monthly Fee: " + b1.Balance;
            decimal monthlyFee = b1.ApplyMonthlyFee();
            Display += "\nFee Charged: " + monthlyFee +
                       "\nNew Balance: " + b1.Balance;

            //// test overdraft mode
            Display += "\n\nOverdraft Mode: Withdraw $100";
            withdraw = b1.Withdraw(100m);
            Display += "\nAmount Withdrawn: " + withdraw +
                       "\nBalance: " + b1.Balance;
            withdraw = b1.Withdraw(500m);
            Display += "\nWithdraw Past Overdraft: Withdraw $500" +
                       "\nAmount Withdrawn: " + withdraw +
                       "\nBalance: " + b1.Balance;

            MessageBox.Show(Display, BankAccount.BankName);
        }
    }
}
