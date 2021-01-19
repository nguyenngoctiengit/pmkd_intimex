using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class ComputerLog
    {
        public string MacAdd { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
    }
}
