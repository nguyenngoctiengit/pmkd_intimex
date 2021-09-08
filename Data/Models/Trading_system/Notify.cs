using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Notify
    {
        public string Code { get; set; }
        public string Tengoi { get; set; }
        public string Tenfull { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
