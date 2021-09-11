using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class PobangTinh
    {
        public string Idunit { get; set; }
        public string Idbt { get; set; }
        public string SoPhieu { get; set; }
        public DateTime? NgayP { get; set; }
        public string SoPkcs { get; set; }
        public string PhieuNhapKhoId { get; set; }
        public string SoPn { get; set; }
        public string TenKhoN { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string Nvnhap { get; set; }
        public string SoHd { get; set; }
        public DateTime? NgayHd { get; set; }
        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? SoLuong { get; set; }
        public string Dvtsl { get; set; }
        public decimal? SoBao { get; set; }
        public string Dvtsb { get; set; }
        public string SoXe { get; set; }
        public decimal? Sltru { get; set; }
        public decimal? Slthuc { get; set; }
        public decimal? GiaTt { get; set; }
        public decimal? TienHang { get; set; }
        public decimal? Vat { get; set; }
        public decimal? TongCong { get; set; }
        public bool? IsGl { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiGiao { get; set; }
        public decimal? TlbaoBi { get; set; }
        public decimal? Tltinh { get; set; }
        public byte Iddong { get; set; }
        public string QuiCach { get; set; }
        public decimal? ChatLuongHd { get; set; }
        public decimal? Tckcs { get; set; }
        public decimal? Vuot { get; set; }
        public decimal? Ptru { get; set; }
        public decimal? LuongTru { get; set; }
        public decimal? LuongTruDc { get; set; }
        public string Iddk { get; set; }
        public Byte[] docs { get; set; }
    }
}
