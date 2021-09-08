using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Nhomhang
    {
        public int Id { get; set; }
        public string NhomHang1 { get; set; }
        public string TenNhom { get; set; }
        public string Dvt { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
