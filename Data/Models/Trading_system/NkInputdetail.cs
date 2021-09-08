using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NkInputdetail
    {
        public string SystemId { get; set; }
        public int Id { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public decimal SoLuong { get; set; }
        public string Dvt { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal ThueNk { get; set; }
        public decimal ThueTtdb { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiaBan1 { get; set; }
        public decimal GiaBan2 { get; set; }
    }
}
