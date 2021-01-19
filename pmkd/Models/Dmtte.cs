using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Dmtte
    {
        public long Id { get; set; }
        public string MaTte { get; set; }
        public DateTime? NgayAd { get; set; }
        public decimal? Tyle { get; set; }
        public decimal? Tyle1 { get; set; }
        public decimal? Tyle2 { get; set; }
    }
}
