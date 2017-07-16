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
        private string clientNumber;

        //Properties

        public string Name
        {
            get { return this.clientName; }
        }
        public string Address
        {
            get { return this.clientAddress; }
        }
        public string Number
        {
            get { return this.clientNumber; }
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

        public virtual void Client1()
        {
            
        }
       

    }
}
