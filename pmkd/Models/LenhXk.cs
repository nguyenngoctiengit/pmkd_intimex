using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class LenhXk
    {
        public long Id { get; set; }
        public string SoLenh { get; set; }
        public string Macn { get; set; }
        public string DvNhan { get; set; }
        public string NguoiMua { get; set; }
        public string Systemref { get; set; }
        public string MaHang { get; set; }
        public decimal SoBao { get; set; }
        public decimal TrongLuong { get; set; }
        public DateTime NgayLam { get; set; }
        public DateTime NgayGiao { get; set; }
        public DateTime CatMang { get; set; }
        public string NguonHang { get; set; }
        public int BaoBi { get; set; }
        public string GiamDinh { get; set; }
        public string Giay { get; set; }
        public string ChongAm { get; set; }
        public string KhuTrung { get; set; }
        public string NhanMac { get; set; }
        public string KiemDem { get; set; }
        public string HangTau { get; set; }
        public string NoiGiao { get; set; }
        public string LienHe { get; set; }
    }
}
