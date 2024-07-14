using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class MessageProcessor<T>
    {
        public delegate void ProcessMessageHandler(T message);

        public void ProcessMessage(T message, ProcessMessageHandler handler)
        {
            handler?.Invoke(message);
        }
    }
}
