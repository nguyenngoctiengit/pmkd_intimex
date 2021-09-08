using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsQtktkl
    {
        public int Id { get; set; }
        public string MaCbNv { get; set; }
        public string LoaiKtkl { get; set; }
        public string SoQd { get; set; }
        public DateTime NgayQd { get; set; }
        public DateTime NgayHl { get; set; }
        public string NoiDung { get; set; }
        public string HinhThuc { get; set; }
        public string NguoiKy { get; set; }
    }
}
