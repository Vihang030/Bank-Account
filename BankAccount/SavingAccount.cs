using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class SavingAccount : BankAccount
    {

        private decimal interest = 0.04M;

        public SavingAccount(int accountNumber, decimal startBalance, string nameOfClient, decimal interest) : base(accountNumber, startBalance, nameOfClient)
        {
            interest = 0.04M;
            Interest = interest;
        }

        public decimal Interest
        {
            get
            {
                return interest;
            }
            set
            {
                if ((value > 0.01M) && (value < 0.2M))
                {
                    interest = value;
                }
            }
        }

        public decimal ApplyMonthlyInterest()
        {
            decimal num = balance * interest;
            balance += num;
            return num;
        }

        public override decimal Withdraw(decimal amount)
        {
            if ((amount > 0M) && (amount < balance))
            {
                balance = (balance - amount) - 0.5M;
                return (amount + 0.5M);
            }
            return 0M;
        }

    }
}
