using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class SanXuat
    {
        public long Id { get; set; }
        public string SoPhieu { get; set; }
        public DateTime? NgayNx { get; set; }
        public string BoPhan { get; set; }
        public string LoaiPhieu { get; set; }
        public string MaKho { get; set; }
        public string LyDo { get; set; }
        public string Macn { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MaCaSx { get; set; }
        public byte[] TimesStamp { get; set; }
    }
}
