using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class SanXuatCt
    {
        public long Id { get; set; }
        public long IdsanXuat { get; set; }
        public string MaHang { get; set; }
        public string Dvt { get; set; }
        public decimal Nw { get; set; }
        public string MaLo { get; set; }
        public byte[] TimesStamp { get; set; }
    }
}
