using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class DangKy4C
    {
        public string MaSo { get; set; }
        public string Macn { get; set; }
        public string TenChuHo { get; set; }
        public long KhuVucId { get; set; }
        public long HuyenId { get; set; }
        public long XaId { get; set; }
        public string DiaChi { get; set; }
        public string Cmnd { get; set; }
        public string DienThoai { get; set; }
        public decimal DienTich { get; set; }
        public long NhomTruongId { get; set; }
        public long DaiLyId { get; set; }
        public decimal SanLuong { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayNhap { get; set; }
        public string Ghichu { get; set; }
        public string UserName { get; set; }
    }
}
