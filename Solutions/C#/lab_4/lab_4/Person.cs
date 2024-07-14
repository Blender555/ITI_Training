using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Person
    {
        public string? Name;
        public int Age;
        public readonly int ID;
        private static int personCount = 0;

        public static int PersonCount
        {
            get { return personCount; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            personCount++;
            ID = personCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, ID: {ID}");
        }
    }
}
