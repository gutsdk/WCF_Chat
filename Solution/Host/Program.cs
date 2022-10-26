using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WCF_Chat.ChatService1)))
            {
                host.Open();
                Console.WriteLine("Хост запущен");
                Console.ReadLine();
            }
        }
    }
}
