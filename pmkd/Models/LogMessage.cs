using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class LogMessage
    {
        public long LogMessageId { get; set; }
        public DateTime DateSend { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Receiver { get; set; }
        public int StatusSend { get; set; }
        public int StatusReceive { get; set; }
        public string Note { get; set; }
        public string FormName { get; set; }
    }
}
