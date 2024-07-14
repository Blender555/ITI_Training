using System;
namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            User shady = new User("Shady");
            User ayman = new User("Ayman");

            // Subscribe using anonymous method
            shady.MessageReceived += delegate (object? sender, MessageEventArgs e)
            {
                var senderUser = sender as User;
                Console.WriteLine($"Anonymous Method: {shady.Name} received message from {senderUser?.Name}: {e.Message}");
            };

            // Subscribe using lambda expression
            ayman.MessageReceived += (sender, e) =>
            {
                var senderUser = sender as User;
                Console.WriteLine($"Lambda Expression: {ayman.Name} received message from {senderUser?.Name}: {e.Message}");
            };

            // Send messages
            shady.SendMessage(ayman, "Hello, Ayman!");
            ayman.SendMessage(shady, "Hello, Shady!");

            shady.Subscribe(shady);

            Console.WriteLine("\n*******************************\n");

            //// Create instances of the User class
            //User ahmed = new User("Ahmed");
            //User mohamed = new User("Mohamed");
            //User ali = new User("Ali");

            //// Subscribe using anonymous method
            //ahmed.MessageReceived += delegate (object? sender, MessageEventArgs e)
            //{
            //    var senderUser = sender as User;
            //    Console.WriteLine($"Anonymous Method: {ahmed.Name} received message from {senderUser?.Name}: {e.Message}");
            //};

            //// Subscribe using lambda expression
            //mohamed.MessageReceived += (sender, e) =>
            //{
            //    var senderUser = sender as User;
            //    Console.WriteLine($"Lambda Expression: {mohamed.Name} received message from {senderUser?.Name}: {e.Message}");
            //};

            //// Send messages
            //ahmed.SendMessage(mohamed, "Hello, Mohamed!");
            //mohamed.SendMessage(ahmed, "Hello, Ahmed!");

            //// Demonstrate multicasting delegates
            //MulticastingExample multicastingExample = new MulticastingExample();
            //multicastingExample.DemonstrateMulticasting();

            //// Demonstrate generic delegates
            //MessageProcessor<string> messageProcessor = new MessageProcessor<string>();
            //messageProcessor.ProcessMessage("Processing a message", message =>
            //{
            //    Console.WriteLine($"Processed Message: {message}");
            //});

        }
    }
}