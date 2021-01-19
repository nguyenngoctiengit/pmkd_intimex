using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class ChiDao
    {
        public long Id { get; set; }
        public string MaDv { get; set; }
        public int Tuan { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string CongViec { get; set; }
        public string NgayGiao { get; set; }
        public string HanHt { get; set; }
        public string CvhoanThanh { get; set; }
        public string CvthucHien { get; set; }
        public string VuongMac { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsLock { get; set; }
        public int Type { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
