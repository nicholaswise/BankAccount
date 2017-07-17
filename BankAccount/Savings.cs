using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        public int savingsBalance;
        //public int depositAmount;

        public int SavingsBalance { get; }
        //public int DepositAmount { get; set; }

        public Savings()
        {

        }
        
        public Savings(int savingsBalance, int accountBalance)
        {
            this.savingsBalance = savingsBalance;
            this.accountBalance = accountBalance;
        }

        public virtual int GetSavBal()
        {
            return savingsBalance;
        }

        public virtual int Deposit(int depositAmount)
        {
            this.savingsBalance += depositAmount;
            return savingsBalance;
        }
        public virtual int Withdrawl(int withdrawlAmount)
        {
            this.savingsBalance -= withdrawlAmount;
            return savingsBalance;
        }
    }
}
