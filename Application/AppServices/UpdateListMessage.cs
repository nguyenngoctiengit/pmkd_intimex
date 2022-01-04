using Data.Public_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppServices
{
    public class UpdateListMessage
    {
        public static void UpdateMessage(int id,string FromUser,string ToUser,string nguoiGui,string Message1)
        {
            Notification notification = new Notification();
            notification.id = id;
            notification.FromUser = FromUser;
            notification.ToUser = ToUser;
            notification.nguoiGui = nguoiGui;
            notification.Message1 = Message1;
            NotificationList.notifications.Add(notification);
        }
    }
}
