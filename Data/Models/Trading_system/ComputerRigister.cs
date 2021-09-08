using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ComputerRigister
    {
        public string ComputerName { get; set; }
        public string MacAdd { get; set; }
        public bool UpdateStatus { get; set; }
        public DateTime? RegDate { get; set; }
        public bool OnlineStatus { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
    }
}
