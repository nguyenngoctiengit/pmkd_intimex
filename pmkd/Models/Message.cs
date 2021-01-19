using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Message
    {
        public string Systemref { get; set; }
        public string Message1 { get; set; }
        public DateTime? Msdate { get; set; }
        public string IdEd { get; set; }
    }
}
