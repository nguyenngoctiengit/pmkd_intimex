using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsNgachluong
    {
        public int Id { get; set; }
        public string MaCn { get; set; }
        public bool? LoaiLuong { get; set; }
        public DateTime NgayAd { get; set; }
        public string NgachLuong { get; set; }
        public decimal LuongCb { get; set; }
        public string GhiChu { get; set; }
    }
}
