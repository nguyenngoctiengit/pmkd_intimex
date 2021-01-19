using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Picture
    {
        public long KFileName { get; set; }
        public byte[] Picture1 { get; set; }
        public string FileName { get; set; }
    }
}
