using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class XepTai
    {
        public XepTai()
        {
            Cans = new HashSet<Can>();
        }

        public int Xeptaiso { get; set; }
        public string SoXe { get; set; }
        public string HopDong { get; set; }
        public long Id { get; set; }
        public DateTime? NgayHd { get; set; }
        public int BagTypeId { get; set; }
        public int SoBao { get; set; }
        public decimal TlBaobi { get; set; }
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string MaKhach { get; set; }
        public string KhachHang { get; set; }
        public int Status { get; set; }
        public bool Iscan { get; set; }
        public DateTime Ngaycan { get; set; }
        public string GhiChu { get; set; }
        public string UserApove { get; set; }
        public int Aprove { get; set; }
        public DateTime NgayVao { get; set; }
        public string PhieuNhapKho { get; set; }
        public string PhieuNhapKhoId { get; set; }
        public bool IsHoanThanh { get; set; }
        public string Kcs { get; set; }
        public string CanId { get; set; }
        public bool Canfinish { get; set; }
        public string Macn { get; set; }
        public string BangTinhId { get; set; }
        public int KhoId { get; set; }
        public string KhoName { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string ApproveTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<Can> Cans { get; set; }
    }
}
