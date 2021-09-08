using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Trandatum
    {
        public string Ref { get; set; }
        public decimal So { get; set; }
        public string TsCountry { get; set; }
        public string ImCountry { get; set; }
        public decimal Ico { get; set; }
        public string Codetau { get; set; }
        public string Codenotify { get; set; }
        public string Nganhang { get; set; }
        public DateTime NgayTau { get; set; }
        public string Person { get; set; }
        public string LoaiIv { get; set; }
        public string Buyer { get; set; }
    }
}
