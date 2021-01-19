using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class LenhGiaoHang
    {
        public long IdLenhGiaoHang { get; set; }
        public string SoLenh { get; set; }
        public int? KhoXuatId { get; set; }
        public string TenKhoXuat { get; set; }
        public decimal? Nw { get; set; }
        public decimal? Gw { get; set; }
        public decimal? Bags { get; set; }
        public int? TypeOfBag { get; set; }
        public string GhiChuBaobi { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string GiamDinh { get; set; }
        public string GiayChongAm { get; set; }
        public string KhuTrung { get; set; }
        public string Hdmb { get; set; }
        public string HdmbId { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string Marking { get; set; }
        public string Taly { get; set; }
        public string HangTau { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string TgcatMang { get; set; }
        public int? Aprove { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsFinish { get; set; }
        public string PhieuCanId { get; set; }
        public string PhieuXuatId { get; set; }
        public string Macn { get; set; }
        public int? Status { get; set; }
        public string NoiGiaoHang { get; set; }
        public string KcsId { get; set; }
        public string GhiChu { get; set; }
        public int? Xeptai { get; set; }
        public string KhachMua { get; set; }
        public string HopdongMua { get; set; }
        public string Booking { get; set; }
        public bool? ChuyenKho { get; set; }
        public int? Loaicont { get; set; }
        public int? Xuatkhau { get; set; }
        public int? Cachdong { get; set; }
        public decimal? Trongluong1con { get; set; }
        public int? Soluongcont { get; set; }
        public string VanChuyen { get; set; }
        public decimal? SoLuongDaGiao { get; set; }
        public long? IdCtHdmb { get; set; }
    }
}
