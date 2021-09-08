using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsDmphepNam
    {
        public string MaCn { get; set; }
        public string MaNPhep { get; set; }
        public string TenNPhep { get; set; }
        public string LoaiPhep { get; set; }
        public string CongThuc { get; set; }
        public string GhiChu { get; set; }
        public int? Stt { get; set; }
        public int? SttColumn { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? IsActive { get; set; }
        public bool? Bold { get; set; }
        public bool? Color { get; set; }
        public short? WColumn { get; set; }
        public string TypeFormat { get; set; }
        public string DataType { get; set; }
    }
}
