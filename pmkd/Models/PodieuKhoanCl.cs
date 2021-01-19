using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class PodieuKhoanCl
    {
        public string Idunit { get; set; }
        public string Iddk { get; set; }
        public byte RquiCach { get; set; }
        public string ColKcs { get; set; }
        public string QuiCach { get; set; }
        public string NhomHang { get; set; }
        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public decimal? ChatLuongHd { get; set; }
        public decimal? ToiDa { get; set; }
        public byte? LoaiTruVuot { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string MaHd { get; set; }
        public bool? NgungSuDung { get; set; }
        public DateTime? NgayNsd { get; set; }
        public bool? Dkchuan { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string GhiChu { get; set; }
    }
}
