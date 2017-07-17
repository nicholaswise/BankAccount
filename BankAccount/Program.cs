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
            Client client1 = new Client("\nJohn Francis Donaghy", "123 Broadway Ave., New York, NY", "212-555-0011");
            Checking checking = new Checking(5000, 50000);
            Savings savings = new Savings(50000, 55000);

            string makeTransaction = "Y";
            string makeTransactionAny = makeTransaction.ToUpper();
            do
            {
                Console.WriteLine("Welcome To Console Bank \nHow can we help you today? ");
                Console.WriteLine("\n1. View Client Information");
                Console.WriteLine("\n2. View Account Balance");
                Console.WriteLine("\n3. Deposit Funds");
                Console.WriteLine("\n4. Withdraw Funds");
                Console.WriteLine("\n5. Exit");
                Console.WriteLine("\n[Type in number for selection and press ENTER]: ");
                //1
                int userSelect = int.Parse(Console.ReadLine());
                while (userSelect < 1 || userSelect > 5)
                {
                    Console.WriteLine("Please select a valid option: ");
                    userSelect = int.Parse(Console.ReadLine());
                }

                if (userSelect == 1)
                {
                    client1.ClientInfo();
                    Console.WriteLine();
                    makeTransactionAny = Transaction();
                    Console.Clear();
                }
                else if (userSelect == 5)
                {
                    Console.WriteLine("Thanks for banking with us. \n");
                    Environment.Exit(0);
                }

                //2


                else if (userSelect == 2)

                {
                    Console.WriteLine("\n1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                    int userSub1 = int.Parse(Console.ReadLine());
                    if (userSub1 == 1)
                    {
                        Console.WriteLine("\nYour balance is: $" + checking.GetCheckBal().ToString("N2"));
                        makeTransactionAny = Transaction();
                        Console.Clear();
                    }
                    else if (userSub1 == 2)
                    {
                        Console.WriteLine("\nYour balance is: $" + savings.GetSavBal().ToString("N2"));
                        makeTransactionAny = Transaction();
                        Console.Clear();
                    }
                }

                //3


                else if (userSelect == 3)
                {
                    Console.WriteLine("\nWhich account? \n1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                    int userResponse03 = int.Parse(Console.ReadLine());
                    if (userResponse03 == 1)
                    {
                        Console.WriteLine("\nTotal to deposit into checking: ");
                        double checkDeposit = double.Parse(Console.ReadLine());
                        checking.Deposit(checkDeposit);
                        Console.WriteLine("\nNew checking balance: $" + checking.GetCheckBal().ToString("N2"));
                        makeTransactionAny = Transaction();
                        Console.Clear();

                    }

                    else if (userResponse03 == 2)
                    {
                        Console.WriteLine("\nTotal to deposit into savings: ");
                        double depositSavings = double.Parse(Console.ReadLine());
                        savings.Deposit(depositSavings);
                        Console.WriteLine("\nNew savings balance: $" + savings.GetSavBal().ToString("N2"));
                        makeTransactionAny = Transaction();
                        Console.Clear();
                    }
                }


                //4


                else if (userSelect == 4)
                {
                    Console.WriteLine("\nWhich account? \n1. Checking \n2. Savings \n[Type in number for selection and press ENTER]: ");
                    int userResponse04 = int.Parse(Console.ReadLine());
                    if (userResponse04 == 1)
                    {
                        Console.WriteLine("\nTotal withdrawl from checking: ");
                        double withdrawlChecking = double.Parse(Console.ReadLine());
                        checking.Withdrawl(withdrawlChecking);
                        Console.WriteLine("\nNew checking balance: $" + checking.GetCheckBal().ToString("N2"));
                        makeTransactionAny = Transaction();
                        Console.Clear();
                    }
                    else if (userResponse04 == 2)
                    {
                        Console.WriteLine("\nTotal withdrawl from savings: ");
                        double withdrawlSavings = double.Parse(Console.ReadLine());
                        savings.Withdrawl(withdrawlSavings);
                        Console.WriteLine("\nNew savings balance: $" + savings.GetSavBal().ToString("N2"));
                        makeTransactionAny = Transaction();
                        Console.Clear();
                    }
                    //5

                    else if (userSelect == 5)
                    {
                        Console.WriteLine("\nThanks for banking with Console Bank! \nHave a nice day.");
                        Environment.Exit(0);
                    }
                }
            } while (makeTransactionAny == "Y");
        }
        public static string Transaction()
        {
            Console.WriteLine("\nDo you want to make another transaction? Y/N");
            string newTransaction = Console.ReadLine().ToUpper();
            if (newTransaction == "N")
            {
                Environment.Exit(0);
            }
            return newTransaction;
        }
    }
}
