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
            Client client1 = new Client("John Francis Donaghy", "123 Central Ave. Parkway, New York, NY", "212-555-0011");
            Checking checking = new Checking(50000, 100000, 5, 00001);

            string makeTransaction = "yes";
            string makeTransactionAny = makeTransaction.ToLower();
            do
            {
                Console.WriteLine("Welcome To Console Bank \nHow can we help you today? ");
                Console.WriteLine("\n\n1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine("[Type in number for selection and press ENTER]: ");
                //1
                int userSelect1 = int.Parse(Console.ReadLine());
                while (userSelect1 < 1 || userSelect1 > 5)
                {
                    Console.WriteLine("Please select a valid option: ");
                    userSelect1 = int.Parse(Console.ReadLine());
                }


                if (userSelect1 == 1)
                {
                    client1.ClientInfo();
                    Console.WriteLine(client1);
                }
                else if (userSelect1 == 5)
                {
                    Console.WriteLine("Thanks for banking with us.");
                    Environment.Exit(0);
                }


                //2

                int userResponse2 = int.Parse(Console.ReadLine());
                if (userResponse2 == 2)
                
                {
                    Console.WriteLine("1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                    int userSub1 = int.Parse(Console.ReadLine());
                    if (userSub1 == 1)
                    {
                        Console.WriteLine("Your balance is: " + checking);
                    }
                    else if (userSelect1 == 2)
                    {
                        Savings balanceSavings = new Savings(100000, 6000);
                        Console.WriteLine("Your balance is: " + balanceSavings);
                    }
                }


                //3
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


                //4
                int userResponse4 = int.Parse(Console.ReadLine());

                if (userResponse4 == 4)
                {
                    Console.WriteLine("Which account? \n1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                    int userResponse04 = int.Parse(Console.ReadLine());
                    if (userResponse04 == 1)
                    {
                        Console.WriteLine("Total withdrawl from checking: ");
                        int withdrawlSavings = int.Parse(Console.ReadLine());
                    }
                    else if (userResponse04 == 2)
                    {
                        Console.WriteLine("Total withdrawl from savings: ");
                        int depositSavings = int.Parse(Console.ReadLine());
                    }
                }


                //5
                int userResponse5 = int.Parse(Console.ReadLine());
                if (userResponse5 == 5)
                {
                    Console.WriteLine("Thanks for banking with Console Bank! \nHave a nice day.");
                    Environment.Exit(0);
                }

            } while (makeTransactionAny == "yes");
        }

        public static string Transaction()
        {
            Console.WriteLine("Do you want to make another transaction? y/n");
            string newTransaction = Console.ReadLine().ToLower();
            Console.Clear();
            if (newTransaction == "no")
            {
                Environment.Exit(0);
            }
            return newTransaction;
        }
    }
}
