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
        public int depositAmount;

        public int SavingsBalance { get; }
        public int DepositAmount { get; set; }

        public Savings()
        {

        }
        
        public Savings(int savingsBalance, int accountBalance)
        {
            this.savingsBalance = savingsBalance;
            this.accountBalance = accountBalance;

            savingsBalance = 5000;
        }
    }
}
