using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Kc
    {
        public long Id { get; set; }
        public string SoPhieu { get; set; }
        public string KhachHang { get; set; }
        public string TenKhach { get; set; }
        public string NguoiGiao { get; set; }
        public int? LoaiBao { get; set; }
        public decimal? TrongLuong { get; set; }
        public string XeVc { get; set; }
        public decimal? TrongluongXe { get; set; }
        public string Mahang { get; set; }
        public string TenHang { get; set; }
        public string Manhom { get; set; }
        public decimal? DoAm { get; set; }
        public decimal? TapChat { get; set; }
        public decimal? DenVo { get; set; }
        public decimal? HatMoc { get; set; }
        public decimal? HatNau { get; set; }
        public decimal? HatCxk { get; set; }
        public decimal? TrangXop { get; set; }
        public decimal? HatChay { get; set; }
        public decimal? HatKhac { get; set; }
        public decimal? Sang8 { get; set; }
        public decimal? Sang12 { get; set; }
        public decimal? Sang13 { get; set; }
        public decimal? Sang14 { get; set; }
        public decimal? Sang15 { get; set; }
        public decimal? Sang16 { get; set; }
        public decimal? Sang17 { get; set; }
        public decimal? Sang18 { get; set; }
        public decimal? Sang19 { get; set; }
        public decimal? Sang20 { get; set; }
        public string Ghichu { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string NguoiKiem { get; set; }
        public decimal? TlChuaghep { get; set; }
        public int? SoLuong { get; set; }
        public int? SlChuaghep { get; set; }
        public string Dvt { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayPhieu { get; set; }
        public string NguoiSua { get; set; }
        public string Macn { get; set; }
        public int? LoaiKcs { get; set; }
        public string CanId { get; set; }
        public decimal? TrongLuongNw { get; set; }
        public string NguoiLayMau { get; set; }
        public long? XeptaiId { get; set; }
        public string AproveName { get; set; }
        public bool? Aprove { get; set; }
        public int? KhoId { get; set; }
        public string PhuTrach { get; set; }
        public string NguonHang { get; set; }
    }
}
