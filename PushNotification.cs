using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodNotificationSystem
{
    public class PushNotification : Notification
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending Push Notification");
        }
    }
}