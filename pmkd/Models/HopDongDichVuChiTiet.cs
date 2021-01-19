using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class HopDongDichVuChiTiet
    {
        public int Id { get; set; }
        public int HopDongDichVuId { get; set; }
        public string XmaHang { get; set; }
        public string NmaHang { get; set; }
        public decimal Phi { get; set; }
    }
}
