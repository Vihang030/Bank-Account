using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Done By: Cliff Patrick
// Description: Base Class for all Bank Accounts
namespace BankAccount
{
    public abstract class BankAccount
    {
        // private instance field
        private string name = "Unknown";
        private int accNumber;
        private DateTime open;
        // protected instance field
        protected decimal balance;
        // public class field
        public const string BankName = "Bank Of VanTrick";

  

        // property for name field
        public string ClientName
        {
            get { return name; }
            set
            {
                // check for empty string
                if (value.Length > 0)
                    name = value;
            }
        }
        // property for account number - read only
        public int AccountNumber
        {
            get { return accNumber; }
        }
        // property for opening date - read only - formatted as string
        public string DateOpen
        {
            get { return open.ToLongDateString(); }
        }
        // property for balance - read only - formatted as currency string
        public string Balance
        {
            get { return balance.ToString("c2"); }
        }

        // constructor
        public BankAccount(int accountNumber, decimal startBalance, string nameOfClient)
        {
            accNumber = accountNumber;
            balance = startBalance;
            ClientName = nameOfClient;
            open = DateTime.Today;
        }

        // public methods
        public override string ToString()
        {
            return "Client Name: " + name +
                    "\nDate Opened: " + DateOpen +
                    "\nAccount Number: " + accNumber +
                    "\nBalance: " + Balance;
        }
        public decimal Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return amount;
            }
            else
                return 0;
        }
        public abstract decimal Withdraw(decimal amount);
    }
}
