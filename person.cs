using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCustomer
{
    abstract class Person
    {
        // Fields
        private string _name, _address;
        private int _number;


        // Constructor
        public Person(string name, string address, int phone)
        {
            _name = name;
            _address = address;
            _number = phone;

        }

        public Person()
        {
            _name = "";
            _address = "";
            _number = 0;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        // Address Property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Telephone Property
        public int Telephone
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
