using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Cash : IPay
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Cash.");
        }
    }
}
