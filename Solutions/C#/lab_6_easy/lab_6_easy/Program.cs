using System;
namespace lab_6_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            User alice = new User("Alice");
            User bob = new User("Bob");

            alice.MessageReceived += delegate (object? sender, MessageEventArgs e)
            {
                Console.WriteLine($"Anonymous method: {alice.Name} received a message from {e.Sender}: {e.Message}");
            };

            bob.MessageReceived += (sender, e) =>
            {
                Console.WriteLine($"Lambda expression: {bob.Name} received a message from {e.Sender}: {e.Message}");
            };

            alice.SendMessage(bob, "Hello Bob!");
            bob.SendMessage(alice, "Hi Alice!");

            Console.ReadLine();
        }
    }
}
