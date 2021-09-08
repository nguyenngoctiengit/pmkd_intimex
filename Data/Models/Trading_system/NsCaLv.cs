using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsCaLv
    {
        public string MaCn { get; set; }
        public int CaLv { get; set; }
        public TimeSpan GioVao { get; set; }
        public TimeSpan GiaRa { get; set; }
    }
}
