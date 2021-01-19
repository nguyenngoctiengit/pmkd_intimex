using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDangvien
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public string MaThe { get; set; }
        public DateTime NgayDb { get; set; }
        public DateTime NgayVao { get; set; }
        public string NoiVao { get; set; }
        public string NoiSh { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayCap { get; set; }
    }
}
