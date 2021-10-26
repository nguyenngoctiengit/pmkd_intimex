using Data.Models.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Public_class {
    public class NotificationList {
        public static List<Message> messages { get; set; } = new List<Message>();
    }
    
}
