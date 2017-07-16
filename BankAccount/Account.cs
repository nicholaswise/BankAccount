using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //Fields
        public int accountNumber;
        public int accountBalance;
        public string accountType;

        //Properties
        public int Number
        {
            get { return this.accountNumber; }
        }
        public int Balance
        {
            get { return this.accountBalance; }
        }
        public string Type
        {
            get { return this.accountType; }
        }

        //Constructors
        public Account()
        {
            //Default
        }
        public Account(int accountNumber, int accountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }
        public virtual string GetAcctBal()
        {
            return "Your balance is " + accountBalance + "\n";
        }
        


    }
}
