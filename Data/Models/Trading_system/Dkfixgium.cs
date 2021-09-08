using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Dkfixgium
    {
        public string IdRow { get; set; }
        public string Systemref { get; set; }
        public string Ref { get; set; }
        public string Sohd { get; set; }
        public string Macn { get; set; }
        public string MuaBan { get; set; }
        public decimal? Trongluong { get; set; }
        public string MaKhach { get; set; }
        public string Mahang { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Slgiao { get; set; }
        public string Dvt { get; set; }
        public int? Solot { get; set; }
        public int? Solotfix { get; set; }
        public decimal? Giact { get; set; }
        public decimal? Giatt { get; set; }
        public int? Vat { get; set; }
        public string Sig { get; set; }
        public decimal? Diff { get; set; }
        public int? Stoploss { get; set; }
        public decimal? Giacuoi { get; set; }
        public DateTime? Ngayfix { get; set; }
        public decimal? Giafix { get; set; }
        public bool? Status { get; set; }
        public DateTime? FNgayfix { get; set; }
        public string Giathang { get; set; }
        public string Gianam { get; set; }
        public string Tiente { get; set; }
        public string IntKy { get; set; }
        public string ClientKy { get; set; }
        public DateTime? Ngayky { get; set; }
        public DateTime? Ngaygiao { get; set; }
        public string Ghichu { get; set; }
        public bool? Isfix { get; set; }
        public bool? IsrateEx { get; set; }
    }
}
