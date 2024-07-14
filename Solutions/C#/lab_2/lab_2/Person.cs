using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_2
{
    internal class Person
    {
        private string? _name;
        private int _age;
        private string? _address;

        public Person()
        { 
            _name = null;
            _age = 0;
            _address = null;
        }

        public Person(string name, int age, string address)
        {
            _name = name;
            _age = age;
            _address = address;
        }

        private Person(bool setDefaults)
        {
            _name = default;
            _age = default;
            _address = default;
        }

        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }

        internal string? Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Address: {_address}");
        }

    }
}
