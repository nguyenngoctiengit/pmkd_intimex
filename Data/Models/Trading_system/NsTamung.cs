using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsTamung
    {
        public string MaCbnv { get; set; }
        public DateTime NgayTu { get; set; }
        public decimal SotienTu { get; set; }
        public string NguoiKyTu { get; set; }
        public string LydoTu { get; set; }
        public string GhiChu { get; set; }
    }
}
