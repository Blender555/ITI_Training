using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public delegate void MessageReceivedHandler<T>(object sender, T message);
    internal class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
