using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Demo.Pub_Sub
{
    public class Notification
    {
        public string NotificationMessage { get; set; }
        public DateTime NotificationDate { get; set; }

        public Notification(string notificationMessage, DateTime notificationDate)
        {
            NotificationMessage = notificationMessage;
            NotificationDate = notificationDate;
        }
    }
}
