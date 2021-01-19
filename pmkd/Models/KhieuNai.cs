using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class KhieuNai
    {
        public long Id { get; set; }
        public string MaDv { get; set; }
        public string KhachHang { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int Tuan { get; set; }
        public decimal Sldk { get; set; }
        public decimal Gtdk { get; set; }
        public decimal Slps { get; set; }
        public decimal Gtps { get; set; }
        public decimal Slgq { get; set; }
        public decimal Gtgq { get; set; }
        public decimal Slth { get; set; }
        public decimal Gtth { get; set; }
        public int Type { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsLock { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
