using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        public double savingsBalance;
        //public int depositAmount;

        public double SavingsBalance { get; }
        //public int DepositAmount { get; set; }

        public Savings()
        {

        }
        
        public Savings(double savingsBalance, double accountBalance)
        {
            this.savingsBalance = savingsBalance;
            this.accountBalance = accountBalance;
        }

        public virtual double GetSavBal()
        {
            return savingsBalance;
        }

        public virtual double Deposit(double depositAmount)
        {
            this.savingsBalance += depositAmount;
            return savingsBalance;
        }
        public virtual double Withdrawl(double withdrawlAmount)
        {
            this.savingsBalance -= withdrawlAmount;
            return savingsBalance;
        }
    }
}
