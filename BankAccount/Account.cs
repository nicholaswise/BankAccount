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
        protected int accountNumber;
        protected int accountBalance;
        protected string accountType;

        //Properties
        protected int Number
        {
            get { return this.accountNumber; }
        }
        protected int Balance
        {
            get { return this.accountBalance; }
        }
        protected string Type
        {
            get { return this.accountType; }
        }

        //Constructors


    }
}
