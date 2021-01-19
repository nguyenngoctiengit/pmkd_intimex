using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NhapKhoChiTiet
    {
        public long Id { get; set; }
        public string NhapKhoId { get; set; }
        public string HopDongId { get; set; }
        public string HopDong { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Dvt { get; set; }
        public decimal? Nw { get; set; }
        public decimal? Rnw { get; set; }
        public decimal? Gw { get; set; }
        public int? SoBao { get; set; }
        public decimal? TlBao { get; set; }
        public int? LoaiBao { get; set; }
        public long? Kcsid { get; set; }
        public string Kcsnumber { get; set; }
        public string TruckNumber { get; set; }
        public byte[] TimeStamp { get; set; }
        public string MaLo { get; set; }

        public virtual NhapKho NhapKho { get; set; }
    }
}
