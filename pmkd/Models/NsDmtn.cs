using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDmtn
    {
        public long Id { get; set; }
        public string MaCn { get; set; }
        public string MaTn { get; set; }
        public string TenTn { get; set; }
        public string LoaiTn { get; set; }
        public string CongThuc { get; set; }
        public string GhiChu { get; set; }
        public int? Stt { get; set; }
        public int? SttColumn { get; set; }
        public string Display { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? IsActive { get; set; }
        public bool? Bold { get; set; }
        public bool? Color { get; set; }
        public short? WColumn { get; set; }
        public string TypeFormat { get; set; }
        public int? Round { get; set; }
    }
}
