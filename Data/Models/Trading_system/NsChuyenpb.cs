using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsChuyenpb
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public DateTime NgayChuyen { get; set; }
        public string DonviOld { get; set; }
        public string TenDvOld { get; set; }
        public string DonviNew { get; set; }
        public string TenDvNew { get; set; }
        public string PbOld { get; set; }
        public string TenPbOld { get; set; }
        public string PbNew { get; set; }
        public string TenPbNew { get; set; }
        public string CvOld { get; set; }
        public string TenCvOld { get; set; }
        public string CvNew { get; set; }
        public string TenCvNew { get; set; }
        public string GhiChu { get; set; }
        public string SoQd { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
    }
}
