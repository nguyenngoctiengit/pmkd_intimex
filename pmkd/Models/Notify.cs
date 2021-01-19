using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Notify
    {
        public string Code { get; set; }
        public string Tengoi { get; set; }
        public string Tenfull { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
