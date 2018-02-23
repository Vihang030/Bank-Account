using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public class ChequingAccount : BankAccount
    { 

        private decimal fee = 10M;
        public ChequingAccount(int accountNumber, decimal startBalance, string nameOfClient, decimal fee) : base(accountNumber, startBalance, nameOfClient)
        {
            fee = 10M;
            Fee = fee;
        }

        public decimal Fee
        {
            get
            {
                return fee;
            }
            set
            {
                if (value > 10M)
                {
                    fee = value;
                }
            }
        }

        public virtual decimal ApplyMonthlyFee()
        {
            base.balance -= fee;
            return fee;
        }


        public override decimal Withdraw(decimal amount)
        {
            if ((amount > 0M) && (amount <= base.balance))
            {
                base.balance -= amount;
                return amount;
            }
            return 0M;
        }

     
    }
}
