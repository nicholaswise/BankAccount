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

        public int SavingsBalance { get; }

        public Savings()
        {
            //default
        }
        public Savings(int savingsBalance)
        {
            savingsBalance = 100000;
        }
    }
}
