using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Data.Models.Trading_system
{
    public class Sp_HDMB_Annex
    {
        public string tenhang { get; set; }
        public decimal trongluong { get; set; }
        public string dvt { get; set; }
        public decimal giact { get; set; }
        public decimal thanhtien { get; set; }
        public decimal VAT { get; set; }
        public string sohd { get; set; }
        public string ngayky { get; set; }
        public string MucUng { get; set; }
        public decimal tongcongtruocVAT { get; set; }
        public string ngaygiaohang { get; set; }
        public string quycach { get; set; }
        public string BaoBi { get; set; }
        public string KiemDinh { get; set; }
        public string ngayhl { get; set; }
        public string ToaKinhTe { get; set; }
        public string phivanchuyen { get; set; }
        public string phibocxep { get; set; }
        [Key]
        public string SoPK { get; set; }
        public string TenA { get; set; }
        public string DiachiA { get; set; }
        public string DienthoaiA { get; set; }
        public string FaxA { get; set; }
        public string EmailA { get; set; }
        public string MasothueA { get; set; }
        public string TaikhoanA { get; set; }
        public string NganhangA { get; set; }
        public string nguoikyA { get; set; }
        public string chucvuA { get; set; }
        public string uyquyenA { get; set; }
        public string TenB { get; set; }
        public string DiachiB { get; set; }
        public string DienthoaiB { get; set; }
        public string FaxB { get; set; }
        public string EmailB { get; set; }
        public string MasothueB { get; set; }
        public string TaikhoanB { get; set; }
        public string NganhangB { get; set; }
        public string nguoikyB { get; set; }
        public string chucvuB { get; set; }
        public string uyquyenB { get; set; }
        public string khac { get; set; }
        public string DiaDiemGiaoHang { get; set; }
        public decimal tongcong { get; set; }


    }
}
