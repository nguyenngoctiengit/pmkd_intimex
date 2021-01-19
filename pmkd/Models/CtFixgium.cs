using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class CtFixgium
    {
        public string Idrow { get; set; }
        public long Idrowdetail { get; set; }
        public string Systemref { get; set; }
        public string Mahang { get; set; }
        public string Dvt { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Solot { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Trongluong { get; set; }
        public string Sig { get; set; }
        public decimal? Diff { get; set; }
        public string Giathang { get; set; }
        public string Gianam { get; set; }
        public int? Solotfix { get; set; }
        public DateTime? Ngayfix { get; set; }
        public decimal? Giafix { get; set; }
        public decimal? Giatt { get; set; }
        public decimal? Giacuoi { get; set; }
        public bool? IsFix { get; set; }
        public int? Status { get; set; }
        public bool? IsrateEx { get; set; }
        public decimal? Tigia { get; set; }
        public string Macn { get; set; }
    }
}
