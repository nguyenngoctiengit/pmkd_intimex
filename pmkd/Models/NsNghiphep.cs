using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsNghiphep
    {
        public int Ident00 { get; set; }
        public string MaCbNv { get; set; }
        public string NoiDung { get; set; }
        public string LoaiPhep { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime NgayKt { get; set; }
        public bool CoPhep { get; set; }
        public string GhiChu { get; set; }
        public decimal SoNgayNghi { get; set; }
        public bool CoTinhLuong { get; set; }
        public string NguoiDuyet { get; set; }
        public DateTime NgayKy { get; set; }
    }
}
