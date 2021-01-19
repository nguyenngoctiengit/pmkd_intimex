using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
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
