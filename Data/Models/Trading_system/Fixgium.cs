using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Fixgium
    {
        public string Idrow { get; set; }
        public string Systemref { get; set; }
        public DateTime? Ngaynhap { get; set; }
        public string Sohd { get; set; }
        public string Ref { get; set; }
        public string Macn { get; set; }
        public string MuaBan { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string Nhanvien { get; set; }
        public string Tiente { get; set; }
        public string IntKy { get; set; }
        public string ClientKy { get; set; }
        public bool? Status { get; set; }
    }
}
