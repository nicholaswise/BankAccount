using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //Fields

        public string clientName;
        public string clientAddress;
        public string clientNumber;

        //Properties

        public string Name
        {
            get;
        }
        public string Address
        {
            get;
        }
        public string Number
        {
            get;
        }

        //Constructors
        public Client()
        {
            //Default
        }
        public Client(string clientName, string clientAddress, string clientNumber)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientNumber = clientNumber;
        }

        public void ClientInfo()
        {
            Console.WriteLine(clientName);
            Console.WriteLine(clientAddress);
            Console.WriteLine(clientNumber);
        }
    }
}
