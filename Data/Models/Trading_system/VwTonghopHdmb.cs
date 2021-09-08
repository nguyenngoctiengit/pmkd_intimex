using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class VwTonghopHdmb
    {
        public string Systemref { get; set; }
        public string Sohd { get; set; }
        public DateTime? Ngayky { get; set; }
        public string Makhach { get; set; }
        public string TenKhach { get; set; }
        public string Macn { get; set; }
        public string MaHang { get; set; }
        public decimal? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? GiaTri { get; set; }
        public string BillNo { get; set; }
        public string Tokhai { get; set; }
        public DateTime? DateBill { get; set; }
    }
}
