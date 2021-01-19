using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsQtct
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public string TenCq { get; set; }
        public string DiaChi { get; set; }
        public string ChucDanh { get; set; }
        public decimal MucLuong { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime NgayKt { get; set; }
        public string GhiChu { get; set; }
        public string BoPhan { get; set; }
    }
}
