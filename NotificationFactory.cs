using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodNotificationSystem
{
    public abstract class NotificationFactory
    {
        public abstract Notification CreateNotification();

        public void Send()
        {
            Notification notification = CreateNotification();
            notification.SendNotification();
        }
    }
}
