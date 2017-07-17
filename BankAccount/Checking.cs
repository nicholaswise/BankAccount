using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        public double checkingBalance;

        public double CheckingBalance { get; }

        public Checking()
        {
            //Default
        }

        public Checking(double checkingBalance, double accountBalance)
        {
            this.checkingBalance = checkingBalance;
            this.accountBalance = accountBalance;
        }

        public virtual double GetCheckBal()
        {
            return checkingBalance;
        }

        public virtual double Deposit(double depositAmount)
        {
            this.checkingBalance += depositAmount;
            return checkingBalance;
        }
        public virtual double Withdrawl(double withdrawlAmount)
        {
            this.checkingBalance -= withdrawlAmount;
            return checkingBalance;
        }
    }
}
