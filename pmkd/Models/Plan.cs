using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Plan
    {
        public string SystemId { get; set; }
        public string SoPa { get; set; }
        public DateTime? NgayPa { get; set; }
        public string DoiTacBan { get; set; }
        public string DanhGiaBan { get; set; }
        public string HdBan { get; set; }
        public string DoiTacMua { get; set; }
        public string DanhGiaMua { get; set; }
        public string HdMua { get; set; }
        public string HangHoa { get; set; }
        public string Dvt { get; set; }
        public decimal? Trongluong { get; set; }
        public decimal? TyGia { get; set; }
        public string NguonVon { get; set; }
        public decimal? LaiSuat { get; set; }
        public int? Songay { get; set; }
        public string Dieukiengiao { get; set; }
        public DateTime? Ngaygiao { get; set; }
        public string ThanhToanMua { get; set; }
        public string ThanhToanBan { get; set; }
        public double? GiaBan { get; set; }
        public double? GiaBanU { get; set; }
        public string Tienteban { get; set; }
        public double? TriGiaBan { get; set; }
        public double? TriGiaBanU { get; set; }
        public double? GiaMua { get; set; }
        public double? GiaMuaU { get; set; }
        public string Tientemua { get; set; }
        public double? TriGiaMua { get; set; }
        public double? TriGiaMuaU { get; set; }
        public double? LaiGop { get; set; }
        public double? Tongchiphi { get; set; }
        public double? CpVanTai { get; set; }
        public double? CpHoaHong { get; set; }
        public double? CpGiaoNhan { get; set; }
        public double? CpLaiVay { get; set; }
        public double? CpQuanLy { get; set; }
        public double? CpKhac { get; set; }
        public double? LaiRong { get; set; }
        public bool? Duyet { get; set; }
        public string Macn { get; set; }
        public bool? TrangthaiGhep { get; set; }
        public decimal Chenhlechmuaban { get; set; }
        public string Tientechenhlech { get; set; }
        public bool Isfix { get; set; }
        public string GhiChu { get; set; }
        public int Trangthai { get; set; }
        public string DienGiaiNguonVon { get; set; }
        public string CtTinhLaiVay { get; set; }
        public string TienTeGn { get; set; }
        public string TienTeHh { get; set; }
        public string TienTeVc { get; set; }
        public string CangGiaoHang { get; set; }
        public string NoiNhanHang { get; set; }
        public double CpCuocTau { get; set; }
        public double CpBaoHiem { get; set; }
        public double CpThc { get; set; }
        public double CpKhuTrung { get; set; }
        public string TienTeQly { get; set; }
        public string TienTeCuocTau { get; set; }
        public string TienTeBaoHiem { get; set; }
        public string TienTeThc { get; set; }
        public string TienTeKhuTrung { get; set; }
        public string TienTeLaiVay { get; set; }
        public string TienTeKhac { get; set; }
        public int SoCont { get; set; }
        public string DvtCt { get; set; }
        public string DvtVcnd { get; set; }
        public string DvtBh { get; set; }
        public string DvtHh { get; set; }
        public string DvtGn { get; set; }
        public string DvtGd { get; set; }
        public string DvtThc { get; set; }
        public string DvtKt { get; set; }
        public string DvtLv { get; set; }
        public string DvtKhac { get; set; }
        public bool IsNew { get; set; }
        public double LoiNhuanSx { get; set; }
        public double ChiPhiSx { get; set; }
    }
}
