using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatService = new ChatServiceImpl();
            var host = new ServiceHost(chatService);

            host.Open();

            Console.WriteLine("Server is running");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            host.Close();
        }
    }
}
