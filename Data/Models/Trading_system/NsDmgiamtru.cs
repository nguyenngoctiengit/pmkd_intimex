using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
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
