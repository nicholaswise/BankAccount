using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Console Bank \nHow can we help you today? ");
            Console.WriteLine("1. View Client Information \n2. View Account Balance \n3. Deposit Funds \n4. Withdraw Funds \n5. Exit \n[Type in number for selection and press ENTER]: ");

            int userResponse1 = int.Parse(Console.ReadLine());
            if (userResponse1 == 1)
            {
                Client client1 = new Client("Wall E", "1 Storage Container Way \nNew York, NY 10001", "212-123-4567");
                Console.WriteLine(client1);
            }


            int userResponse2 = int.Parse(Console.ReadLine());
            if (userResponse2 == 2)
            {
                Console.WriteLine("1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                int userSelect1 = int.Parse(Console.ReadLine());
                if (userSelect1 == 1)
                {
                    Checking checkingBalance = new BankAccount.Checking();
                    Console.WriteLine("Your balance is: " + checkingBalance);
                }
                else if (userSelect1 == 2)
                {
                    Savings balanceSavings = new BankAccount.Savings();
                    Console.WriteLine("Your balance is: " + balanceSavings);
                }
            }
            int userResponse3 = int.Parse(Console.ReadLine());
            if (userResponse3 == 3)
            {
                Console.WriteLine("Which account? \n1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                int userResponse03 = int.Parse(Console.ReadLine());
                if (userResponse03 == 1)
                {
                    Console.WriteLine("Total to deposit into checking: ");
                    int depositChecking = int.Parse(Console.ReadLine());
                }

                else if (userResponse03 == 2)
                {
                    Console.WriteLine("Total to deposit into savings: ");
                    int depositSavings = int.Parse(Console.ReadLine());
                }
                
            }




        }
    }
}
