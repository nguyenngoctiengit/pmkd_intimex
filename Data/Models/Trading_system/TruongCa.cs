using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TruongCa
    {
        public long Id { get; set; }
        public string Macn { get; set; }
        public string TruongCa1 { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
