using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ConfigReport
    {
        public long Id { get; set; }
        public string ReportName { get; set; }
        public string Title { get; set; }
        public string DocName { get; set; }
        public string Note { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
