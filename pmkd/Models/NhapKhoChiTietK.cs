using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NhapKhoChiTietK
    {
        public int stt { get; set; }
        public long Id { get; set; }
        public string NhapKhoId { get; set; }
        public string RsoPhieu { get; set; }
        public string RhopDongId { get; set; }
        public string RhopDong { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Dvt { get; set; }
        public decimal? Gw { get; set; }
        public decimal Rnw { get; set; }
        public decimal? TlTru { get; set; }
        public decimal? TyLeTru { get; set; }
        public int? HinhThucTru { get; set; }
        public long? XepTaiId { get; set; }
        public int? SoBao { get; set; }
        public decimal? TlBao { get; set; }
        public int? LoaiBao { get; set; }
        public decimal? DonGia { get; set; }
        public string GiaTl { get; set; }
        public decimal? DonGiaDc { get; set; }
        public long? Kcsid { get; set; }
        public string Kcsnumber { get; set; }
        public string TruckNumber { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Macn { get; set; }
        public string Ghichu { get; set; }
        public decimal? Sotienung { get; set; }
        public DateTime? Ngayung { get; set; }
        public decimal? Laisuat { get; set; }
        public decimal? Stoploss { get; set; }
        public bool? Approve { get; set; }
        public DateTime? Approvedate { get; set; }

        public virtual NhapKhoK NhapKho { get; set; }
    }
}
