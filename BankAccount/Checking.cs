using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {


        protected int checkingBalance;

        public int CheckingBalance { get; }

        public Checking()
        {
            //default
        }
        public Checking(int checkingBalance)
        {
            checkingBalance = 1000;
        }

        




    }
}
