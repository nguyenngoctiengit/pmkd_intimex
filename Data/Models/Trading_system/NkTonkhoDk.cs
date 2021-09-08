using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NkTonkhoDk
    {
        public int Identify { get; set; }
        public string TkNhap { get; set; }
        public DateTime NgayTk { get; set; }
        public string MaKho { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Dvt { get; set; }
        public decimal SoluongTk { get; set; }
        public decimal GiaTriTk { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaBan1 { get; set; }
        public decimal GiaBan2 { get; set; }
        public string Macn { get; set; }
    }
}
