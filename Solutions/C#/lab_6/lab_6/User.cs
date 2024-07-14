using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class User
    {
        public string Name { get; private set; }
        public event EventHandler<MessageEventArgs> MessageReceived;

        public User(string name)
        {
            Name = name;
        }

        public void SendMessage(User receiver, string message)
        {
            Console.WriteLine($"{Name} sends {message} to {receiver.Name}");
            receiver.OnMessageReceived(new MessageEventArgs(message));
        }

        protected virtual void OnMessageReceived(MessageEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }

        public void Subscribe(User user)
        {
            user.MessageReceived += HandleMessageReceived;
        }

        public void Unsubscribe(User user)
        {
            user.MessageReceived -= HandleMessageReceived;
        }

        private void HandleMessageReceived(object? sender, MessageEventArgs e)
        {
            var senderUser = sender as User;
            Console.WriteLine($"{Name} received {e.Message} from {senderUser?.Name}");
        }
    }
}
