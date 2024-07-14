using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Cashier
    {
        private IPay paymentMethod;

        public Cashier(IPay method)
        {
            paymentMethod = method;
        }

        public void Checkout(decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
