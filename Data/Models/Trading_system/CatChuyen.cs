using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class CatChuyen
    {
        public string SoYeuCau { get; set; }
        public int LyDo { get; set; }
        public string XphieuXuat { get; set; }
        public string XtenKhach { get; set; }
        public string XhopDong { get; set; }
        public string XmaHang { get; set; }
        public decimal XsoLuong { get; set; }
        public string NphieuNhap { get; set; }
        public string NhopDong { get; set; }
        public string NmaHang { get; set; }
        public decimal NsoLuong { get; set; }
        public int XkhoXuatId { get; set; }
        public string XkhoXuat { get; set; }
        public string XhopDongId { get; set; }
        public string XtenHang { get; set; }
        public string XmaKhach { get; set; }
        public int XloaiBao { get; set; }
        public int? XsoBao { get; set; }
        public string NtenKhach { get; set; }
        public int NkhoNhapId { get; set; }
        public string NkhoNhap { get; set; }
        public string NhopDongId { get; set; }
        public string NtenHang { get; set; }
        public string NmaKhach { get; set; }
        public int? NloaiBao { get; set; }
        public int? NsoBao { get; set; }
        public string GhiChu { get; set; }
        public bool IsPrint { get; set; }
        public DateTime NgayPhieu { get; set; }
        public DateTime NgayNhap { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Macn { get; set; }
        public bool? IsDropShip { get; set; }
        public long Id { get; set; }
        public int HopDongDichVuId { get; set; }
        public string HopDongDichVu { get; set; }
        public decimal ChiPhi { get; set; }
        public string DonViTinh { get; set; }
        public long? IdXepTai { get; set; }
        public decimal? TyLeTru { get; set; }
        public decimal? GiaHd { get; set; }
        public decimal? GiaTruCl { get; set; }
        public decimal? GiaTruDc { get; set; }
        public decimal? Sotienung { get; set; }
        public decimal? Laisuat { get; set; }
        public DateTime? Ngayung { get; set; }
        public decimal? Stoploss { get; set; }
        public long? Xidchitiet { get; set; }
        public long? Nidchitiet { get; set; }
    }
}
