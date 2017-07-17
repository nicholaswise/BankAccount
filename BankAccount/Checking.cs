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
        //public int depositAmount;
        //public int withdrawlAmount;

        public double CheckingBalance { get; }
        //public int DepositAmount { get; set; }
        //public int WithdrawlAmount { get; set; }

        public Checking()
        {

        }

        public Checking(double checkingBalance, double accountBalance) //int depositAmount)
        {
            this.checkingBalance = checkingBalance;
            this.accountBalance = accountBalance;
            //this.depositAmount = depositAmount;
            //this.accountNumber = accountNumber;
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
