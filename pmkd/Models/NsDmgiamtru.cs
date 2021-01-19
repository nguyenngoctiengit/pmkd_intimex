using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDmgiamtru
    {
        public long Id { get; set; }
        public DateTime NgayAd { get; set; }
        public decimal GtBanthan { get; set; }
        public decimal GtPhuthuoc { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayKt { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
