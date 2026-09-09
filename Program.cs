using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodNotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory factory;

            factory = new EmailFactory();
            factory.Send();

            factory = new SMSFactory();
            factory.Send();

            factory = new PushFactory();
            factory.Send();

            Console.ReadLine();
        }
    }
}
