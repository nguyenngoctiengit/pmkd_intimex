using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Picture
    {
        public long KFileName { get; set; }
        public byte[] Picture1 { get; set; }
        public string FileName { get; set; }
    }
}
