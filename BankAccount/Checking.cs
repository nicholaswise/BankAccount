using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {


        public int checkingBalance;
        //public int depositAmount;
        //public int withdrawlAmount;

        public int CheckingBalance { get; }
        //public int DepositAmount { get; set; }
        //public int WithdrawlAmount { get; set; }

        public Checking()
        {

        }

        public Checking(int checkingBalance, int accountBalance) //int depositAmount)
        {
            this.checkingBalance = checkingBalance;
            this.accountBalance = accountBalance;
            //this.depositAmount = depositAmount;
            //this.accountNumber = accountNumber;
        }

        public virtual int GetCheckBal()
        {
            return checkingBalance;
        }

        public virtual int Deposit(int depositAmount)
        {
            this.checkingBalance += depositAmount;
            return checkingBalance;
        }
        public virtual int Withdrawl(int withdrawlAmount)
        {
            this.checkingBalance -= withdrawlAmount;
            return checkingBalance;
        }










    }
}
