using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Hdmb
    {
        public string Macn { get; set; }
        [Required]
        public string Systemref { get; set; }
        [Required]
        public string Ref { get; set; }
        [Required]
        public string Sohd { get; set; }
        public int? Trangthai { get; set; }
        [Required]
        public string MuaBan { get; set; }
        [Required]
        public string Makhach { get; set; }
        public DateTime? Ngayky { get; set; }
        public DateTime? Ngaygiao { get; set; }
        public DateTime? Ngayhl { get; set; }
        public DateTime? Ngaytl { get; set; }
        public string Nguoitl { get; set; }
        public string Nguoilam { get; set; }
        public string Ghichu { get; set; }
        public bool? Pakd { get; set; }
        public string SoPakd { get; set; }
        public bool? IsFix { get; set; }
        public string Tiente { get; set; }
        [Required]
        public long? ThanhtoanId { get; set; }
        public string Thanhtoan { get; set; }
        public DateTime? Ngaylam { get; set; }
        [Required]
        public string IntKy { get; set; }
        [Required]
        public string ClientKy { get; set; }
        public bool? Docstatus { get; set; }
        public bool? TrangthaiGhep { get; set; }
        public decimal TienUngHd { get; set; }
        public decimal TienUngTt { get; set; }
        public string HdcmuonId { get; set; }
        public string SoHdcmuon { get; set; }
        [Required]
        public string DiaDiemGiaoHang { get; set; }
        public bool IsNoKhoDoi { get; set; }
        public int TypeKd { get; set; }
        public string VanChuyen { get; set; }
        public DateTime? NgayTraPhaitra { get; set; }
        public string Tenfull { get; set; }
    }
}
