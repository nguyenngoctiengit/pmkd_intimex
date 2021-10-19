using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.SignalR
{
    public partial class Message
    {
        public int Id { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message1 { get; set; }
        public DateTime? Date { get; set; }

        public virtual AspNetUser FromUserNavigation { get; set; }
        public virtual AspNetUser ToUserNavigation { get; set; }
    }
}
