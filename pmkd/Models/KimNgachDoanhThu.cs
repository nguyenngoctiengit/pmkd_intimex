using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class KimNgachDoanhThu
    {
        public long Id { get; set; }
        public DateTime NgayCt { get; set; }
        public string SoHd { get; set; }
        public string LoaiHinh { get; set; }
        public string NhomHang { get; set; }
        public string Dvt { get; set; }
        public decimal SoLuong { get; set; }
        public decimal KimNgach { get; set; }
        public decimal TyGia { get; set; }
        public decimal DoanhThu { get; set; }
        public int Tuan { get; set; }
        public int Thang { get; set; }
        public int Qui { get; set; }
        public int Nam { get; set; }
        public int NamLv { get; set; }
        public bool DuyetTuan { get; set; }
        public bool DuyetThang { get; set; }
        public bool DuyetQui { get; set; }
        public bool DuyetNam { get; set; }
        public string GhiChu { get; set; }
        public DateTime CreateDate { get; set; }
        public string MaDvCs { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
