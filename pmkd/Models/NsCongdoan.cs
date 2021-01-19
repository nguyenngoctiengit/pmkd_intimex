using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsCongdoan
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public string MaThe { get; set; }
        public DateTime NgayVao { get; set; }
        public string NoiVao { get; set; }
        public string TrucThuoc { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayCap { get; set; }
    }
}
