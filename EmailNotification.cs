using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodNotificationSystem
{
    public class EmailNotification : Notification
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending Email Notification");
        }
    }
}
