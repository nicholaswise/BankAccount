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
        private static int depositAmount;

        public int CheckingBalance { get; }

        public Checking(int checkingBalance, int accountBalance)
        {
            this.checkingBalance = checkingBalance;
            this.accountBalance = accountBalance;
        }


        public static void Add()
        {
            return;
        }







    }
}
