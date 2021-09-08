using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TonDau
    {
        public long Id { get; set; }
        public string BranchId { get; set; }
        public string DonVi { get; set; }
        public int Tuan { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int Type { get; set; }
        public decimal GtTon { get; set; }
        public decimal GtNhap { get; set; }
        public decimal GtXuat { get; set; }
        public decimal GtTrungBay { get; set; }
        public string GhiChu { get; set; }
        public bool IsLock { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
