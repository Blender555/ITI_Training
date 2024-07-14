using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Dog : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hoho");
        }
        public void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }
}
