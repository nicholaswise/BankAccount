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

        public virtual string ClientInfo()
        {
            return
            clientName = "Wall E";
            clientAddress = "1 Storage Container Way \nNew York, NY \n10001";
            clientNumber = "212-123-4567";
        }
       

    }
}
