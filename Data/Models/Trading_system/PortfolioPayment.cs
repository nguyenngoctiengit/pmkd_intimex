using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class PortfolioPayment
    {
        public long Id { get; set; }
        public string Matt { get; set; }
        public string TenTt { get; set; }
        public int? Mucung { get; set; }
        public int ThanhToan { get; set; }
        public bool Ungtien { get; set; }
        public int? ReportName { get; set; }
        public string LoaiHd { get; set; }
        public int HinhThucGia { get; set; }
    }
}
