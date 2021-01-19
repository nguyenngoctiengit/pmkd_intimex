using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class HopDongDichVu
    {
        public int Id { get; set; }
        public string SoHopDong { get; set; }
        public DateTime? NgayHd { get; set; }
        public DateTime? NgayHl { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public bool ThanhLy { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
