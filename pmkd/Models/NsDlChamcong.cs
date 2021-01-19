using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDlChamcong
    {
        public long Id { get; set; }
        public string MaCn { get; set; }
        public string MaCc { get; set; }
        public string MaCbnv { get; set; }
        public DateTime? NgayTgVao { get; set; }
        public DateTime? NgayTgRa { get; set; }
    }
}
