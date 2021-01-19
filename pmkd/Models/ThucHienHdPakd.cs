using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class ThucHienHdPakd
    {
        public long Id { get; set; }
        public string MaDv { get; set; }
        public string Nhom { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int Tuan { get; set; }
        public string NhomHang { get; set; }
        public double LaiPa { get; set; }
        public double UocLai { get; set; }
        public string GhiChu { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsLock { get; set; }
        public int Type { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
