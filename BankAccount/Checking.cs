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
        private double depositAmount;

        public int CheckingBalance { get; }
        public double DepositAmount { get; set; }

        public Checking()
        {

        }

        public Checking(int checkingBalance, int accountBalance, double depositAmount, int accountNumber)
        {
            this.checkingBalance = checkingBalance;
            this.accountBalance = accountBalance;
            this.depositAmount = depositAmount;
            this.accountNumber = accountNumber;
        }

        public virtual int GetCheckBal()
        {
            return accountBalance;
        }

        //public override double Deposit(double depositAmount)
        //{
        //    this.checkingBalance += depositAmount;
        //    return Balance;
        //}


        







    }
}
