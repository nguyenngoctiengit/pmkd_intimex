using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TBaoCao
    {
        public string MaCbnv { get; set; }
        public string TenCbNv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string MaCn { get; set; }
        public string MaBp { get; set; }
        public string ChucVu { get; set; }
        public string LevelI { get; set; }
        public string Bold { get; set; }
    }
}
