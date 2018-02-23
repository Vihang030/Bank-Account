using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class PremiumAccount : ChequingAccount
    {

        private decimal over = 100M;
        public PremiumAccount(int accountNumber, decimal startBalance, string nameOfClient, decimal fee, decimal overdraft) : base(accountNumber, startBalance, nameOfClient, fee)
        {
            over = 100M;
            OverDraft = overdraft;
        }


        public decimal OverDraft
        {
            get
            {
                return over;
            }
            set
            {
                if (value > 100M)
                {
                    over = value;
                }
            }
        }

        public override decimal Withdraw(decimal amount)
        {
            if (amount < 0M)
            {
                return 0M;
            }
            if ((balance - amount) <= -OverDraft)
            {
                return 0M;
            }
            balance -= amount;
            decimal num = 0M;
            if (balance < 0M)
            {
                num = Math.Abs((decimal)(balance * 0.02M));
                balance -= num;
            }
            return (amount + num);
        }

        public override decimal ApplyMonthlyFee()
        {
            decimal num = Fee + 2M;
            balance -= num;
            return num;
        }



    }
}
