using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_easy
{
    internal class User
    {
        public string Name { get; }
        public event EventHandler<MessageEventArgs> MessageReceived;

        public User(string name)
        {
            Name = name;
        }

        public void SendMessage(User receiver, string message)
        {
            Console.WriteLine($"{Name} sends message to {receiver.Name}: {message}");
            receiver.OnMessageReceived(this, new MessageEventArgs(Name, message));
        }

        protected virtual void OnMessageReceived(object sender, MessageEventArgs e)
        {
            MessageReceived?.Invoke(sender, e);
        }
    }
}
