using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodNotificationSystem
{
    public class PushFactory : NotificationFactory
    {
        public override Notification CreateNotification()
        {
            return new PushNotification();
        }
    }
}