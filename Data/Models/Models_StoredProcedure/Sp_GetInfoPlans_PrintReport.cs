using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GetInfoPlans_PrintReport
    {
        public string NgayPA { get; set; }
        public string DoiTacBan { get; set; }
        public string HD_Ban { get; set; }
        public string DanhGiaBan { get; set; }
        public string DoiTacMua { get; set; }
        public string HD_Mua { get; set; }
        public string DanhGiaMua { get; set; }
        public string HangHoa { get; set; }
        public string Trongluong { get; set; }
        public string CangGiaoHang { get; set; }
        public string NoiNhanHang { get; set; }
        public string TyGia { get; set; }
        public string LaiSuat { get; set; }
        public string DienGiai_NguonVon { get; set; }
        public string dieukiengiao { get; set; }
        public string ngaygiao { get; set; }
        public string ThanhToanBan { get; set; }
        public string ThanhToanMua { get; set; }
        public string dvt { get; set; }
        public string tientemua { get; set; }
        public string tienteban { get; set; }
        public string TienTe_Vc { get; set; }
        public string TienTe_Hh { get; set; }
        public string TienTe_Gn { get; set; }
        public string LaiRong { get; set; }
        public string TienTe_CuocTau { get; set; }
        public string TienTe_BaoHiem { get; set; }
        public string TienTe_Qly { get; set; }
        public string TienTe_THC { get; set; }
        public string TienTe_KhuTrung { get; set; }
        public string TienTe_LaiVay { get; set; }
        public string TienTe_Khac { get; set; }
        public string GiaBanU { get; set; }
        public string Dvt_CT { get; set; }
        public string Dvt_Vcnd { get; set; }    
        public string Dvt_BH { get; set; }
        public string Dvt_HH { get; set; }
        public string Dvt_GN { get; set; }
        public string Dvt_GD { get; set; }
        public string Dvt_THC { get; set; }
        public string Dvt_KT { get; set; }
        public string Dvt_Khac { get; set; }
        public string Dvt_LV { get; set; }
        public string TriGiaBanU { get; set; }
        public string TriGiaBanV { get; set; }
        public string GiaMuaU { get; set; }
        public string TriGiaMuaU { get; set; }
        public string TriGiaMuaV { get; set; }
        public string CT_TinhLaiVay { get; set; }
        [Key]
        public string soPA { get; set; }
        public string LaiGop { get; set; }
        public string GhiChu { get; set; }
        public string TongChiPhi { get; set; }
        public string TL_LoiNhuan { get; set; }
        public string CpVanTai { get; set; }
        public string CpHoaHong { get; set; }
        public string CpGiaoNhan { get; set; }
        public string CpLaiVay { get; set; }
        public string CpQuanLy { get; set; }
        public string CpKhac { get; set; }
        public string CpCuocTau { get; set; }
        public string CpBaoHiem { get; set; }
        public string CpTHC { get; set; }
        public string CpKhuTrung { get; set; }
        public string CpCuocTau_U { get; set; }
        public string CpVanTai_U { get; set; }
        public string CpBaoHiem_U { get; set; }
        public string CpHoaHong_U { get; set; }
        public string CpGiaoNhan_U { get; set; }
        public string CpQuanLy_U { get; set; }
        public string CpTHC_U { get; set; }
        public string CpKhuTrung_U { get; set; }
        public string CpLaiVay_U { get; set; }
        public string CpKhac_U { get; set; }
        public string CpCuocTau_V { get; set; }
        public string CpVanTai_V { get; set; }
        public string CpBaoHiem_V { get; set; }
        public string CpHoaHong_V { get; set; }
        public string CpGiaoNhan_V { get; set; }
        public string CpQuanLy_V { get; set; }
        public string CpTHC_V { get; set; }
        public string CpKhuTrung_V { get; set; }
        public string CpLaiVay_V { get; set; }
        public string CpKhac_V { get; set; }
        public double LoiNhuan_SX { get; set; }
        public double ChiPhi_SX { get; set; }
        public string GiaTamTinhU { get; set; }
        public string GiaTamTinh { get; set; }
        public string ChenhLechU { get; set; }
        public string ChenhLech { get; set; }
    }
}
