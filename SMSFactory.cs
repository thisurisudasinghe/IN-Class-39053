using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodNotificationSystem
{
    public class SMSFactory : NotificationFactory
    {
        public override Notification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
