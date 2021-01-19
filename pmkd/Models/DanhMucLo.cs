using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DanhMucLo
    {
        public DateTime? NgayTao { get; set; }
        public string MaLo { get; set; }
        public string TenLo { get; set; }
        public string MaKho { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public decimal? Nw { get; set; }
        public int? TrangThai { get; set; }
        public int? LoaiLo { get; set; }
        public string NguonHang { get; set; }
        public decimal? DoAm { get; set; }
        public decimal? TapChat { get; set; }
        public decimal? DenVo { get; set; }
        public decimal? HatMoc { get; set; }
        public decimal? HatNau { get; set; }
        public decimal? HatCxk { get; set; }
        public decimal? HatTrangxop { get; set; }
        public decimal? HatChay { get; set; }
        public decimal? HatKhac { get; set; }
        public decimal? Sang18 { get; set; }
        public decimal? Sang16 { get; set; }
        public decimal? Sang13 { get; set; }
        public decimal? Sang12 { get; set; }
        public decimal? Sang17 { get; set; }
        public decimal? Sang19 { get; set; }
        public decimal? Sang20 { get; set; }
        public byte[] TimesStamp { get; set; }
        public long Id { get; set; }
        public string Macn { get; set; }
    }
}
