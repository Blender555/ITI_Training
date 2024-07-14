using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class MulticastingExample
    {
        public delegate void Notify();

        public void NotifyMethod1()
        {
            Console.WriteLine("Notify Method 1 called");
        }

        public void NotifyMethod2()
        {
            Console.WriteLine("Notify Method 2 called");
        }

        public void DemonstrateMulticasting()
        {
            Notify notifyDelegate = NotifyMethod1;
            notifyDelegate += NotifyMethod2;

            notifyDelegate.Invoke();
        }
    }
}
