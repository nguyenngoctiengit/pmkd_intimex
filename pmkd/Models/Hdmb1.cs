using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Hdmb1
    {
        public long Id { get; set; }
        public DateTime Ngayky { get; set; }
        public string Mahang { get; set; }
        public string Manhom { get; set; }
        public decimal Trongluong { get; set; }
        public decimal Giact { get; set; }
        public string Giathang { get; set; }
        public string Gianam { get; set; }
        public bool Isfix { get; set; }
        public decimal Diff { get; set; }
        public string Sig { get; set; }
        public string MuaBan { get; set; }
        public string Tiente { get; set; }
        public string Macn { get; set; }
    }
}
