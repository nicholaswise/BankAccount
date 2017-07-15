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

        private string clientName;
        private string clientAddress;
        private double clientNumber;

        //Properties

        private string Name
        {
            get { return this.clientName; }
        }
        private string Address
        {
            get { return this.clientAddress; }
        }
        private double Number
        {
            get { return this.clientNumber; }
        }

        //Constructors
        public Client()
        {
            //Default
        }
        public Client(string clientName, string clientAddress, double clientNumber)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientNumber = clientNumber;
        }
       

    }
}
