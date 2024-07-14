using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_linq
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode()
        {
            int Hash = 11;
            Hash = Hash * 13 + Name.GetHashCode();
            Hash = Hash * 13 + Age.GetHashCode();
            return Hash;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2) => !(p1 == p2);

        public void ComparePersons(Person p)
        {
            Console.WriteLine($"Using Equals(): {this.Equals(p)}");
            Console.WriteLine($"Using == operator: {this == p}");
        }
    }
}
