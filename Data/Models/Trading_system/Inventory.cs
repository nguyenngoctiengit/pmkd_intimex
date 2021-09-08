using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Inventory
    {
        public long Id { get; set; }
        public string Macn { get; set; }
        public string SoPhieu { get; set; }
        public string Systemref { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Dvt { get; set; }
        public decimal SoBao { get; set; }
        public decimal TrongLuong { get; set; }
        public DateTime NgayKhoaSo { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal DoAm { get; set; }
        public decimal TapChat { get; set; }
        public decimal DenVo { get; set; }
        public decimal Sang12 { get; set; }
        public decimal Sang13 { get; set; }
        public decimal Sang16 { get; set; }
        public decimal Sang18 { get; set; }
        public string Stock { get; set; }
    }
}
