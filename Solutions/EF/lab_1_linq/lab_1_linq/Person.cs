using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_linq
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return (Name, Age).GetHashCode();
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, p2))
            {
                return true;
            }
            if (p1 is null || p2 is null)
            {
                return false;
            }
            return p1.Name == p2.Name && p1.Age == p2.Age;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }

        public void ComparePersons(Person p)
        {
            Console.WriteLine($"Using Equals(): {this.Equals(p)}");
            Console.WriteLine($"Using == operator: {this == p}");
        }
    }
}
