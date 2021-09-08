using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ServiceCenterInfo
    {
        public string MServer { get; set; }
        public int? MPort { get; set; }
        public int? Mtype { get; set; }
    }
}
