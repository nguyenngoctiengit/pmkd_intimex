using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DkctHdmb
    {
        public string IdRow { get; set; }
        public string Systemref { get; set; }
        public string Ref { get; set; }
        public int Soluong { get; set; }
        public decimal Trongluong { get; set; }
        public decimal? Trongluongdagiao { get; set; }
        public string Mahang { get; set; }
        public string Dvt { get; set; }
        public decimal Giact { get; set; }
        public decimal Giatt { get; set; }
        public decimal Vat { get; set; }
        public string Sig { get; set; }
        public decimal? Diff { get; set; }
        public decimal? Stoploss { get; set; }
        public decimal Giacuoi { get; set; }
        public DateTime? Ngayfix { get; set; }
        public decimal Solot { get; set; }
        public bool? Status { get; set; }
        public DateTime? FNgayfix { get; set; }
        public string Giathang { get; set; }
        public string Gianam { get; set; }
        public string DvtTheoHd { get; set; }
        public decimal GiaTheoHd { get; set; }
    }
}
