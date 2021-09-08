using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class MessageOffline
    {
        public long Id { get; set; }
        public string UserReceive { get; set; }
        public string UserSend { get; set; }
        public DateTime EntDate { get; set; }
        public string Contents { get; set; }
    }
}
