using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Cat : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void Move()
        {
            Console.WriteLine("Cat is moving");
        }
    }
}
