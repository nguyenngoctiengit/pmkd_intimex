using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class MayTinhInfor
    {
        public long MayTinhId { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string Windows { get; set; }
        public string Antivirut { get; set; }
        public string Office { get; set; }
        public string Email { get; set; }
        public string OtherSoft { get; set; }
        public string GhiChu { get; set; }
    }
}
