using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class XuatKhoChiTiet
    {
        public long Id { get; set; }
        public string XuatKhoId { get; set; }
        public string HopDongId { get; set; }
        public string HopDong { get; set; }
        public string RhopDongId { get; set; }
        public string RhopDong { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Dvt { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public decimal Rnw { get; set; }
        public int SoBao { get; set; }
        public decimal? TlBao { get; set; }
        public int LoaiBao { get; set; }
        public long? Kcsid { get; set; }
        public string Kcsnumber { get; set; }
        public string TruckNumber { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Macn { get; set; }
        public bool? IsTach { get; set; }
        public bool? Finishtach { get; set; }
        public string RsoPhieuTach { get; set; }
        public bool? Isdelete { get; set; }

        public virtual XuatKho XuatKho { get; set; }
    }
}
