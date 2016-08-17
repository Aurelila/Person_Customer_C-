using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCustomer
{
    class Customer : Person
    {
        // Fields
        private string custNumber;
        private bool mailing;

        // Constructor
        public Customer(string name, string address, int phone, string custNum, bool mail)
            : base(name, address, phone)
        {
            custNumber = custNum;
            mailing = mail = true;
        }


        // Customer Number Property
        public string CustomerNum
        {
            get { return custNumber; }
            set { custNumber = value; }
        }

        // Mailing Property
        public bool Mailing
        {
            get { return mailing; }
            set { mailing = value; }
        }

    }
}

