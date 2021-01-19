using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class LogCan
    {
        public long LogCanId { get; set; }
        public string PhieuCan { get; set; }
        public int LanCan { get; set; }
        public DateTime NgayCan { get; set; }
        public string GioCan { get; set; }
        public decimal TrongLuong { get; set; }
        public string TruckNo { get; set; }
        public int HinhThucCan { get; set; }
    }
}
