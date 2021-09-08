using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class BaoTriMayTinh
    {
        public long Id { get; set; }
        public string Nguoidung { get; set; }
        public DateTime? ThoiGianBao { get; set; }
        public string Lydo { get; set; }
        public string NhanVienTh { get; set; }
        public DateTime? ThoigianTh { get; set; }
        public string BienPhapXl { get; set; }
        public long? MayTinhId { get; set; }
        public DateTime? ThoiGianHoanThanh { get; set; }
    }
}
