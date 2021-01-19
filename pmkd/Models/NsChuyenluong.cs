using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsChuyenluong
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public bool? LoaiLuong { get; set; }
        public DateTime NgayChuyen { get; set; }
        public int HtLuong { get; set; }
        public string Ngach205 { get; set; }
        public decimal Hs205 { get; set; }
        public string NgachQc { get; set; }
        public decimal LuongQc { get; set; }
        public decimal? PcQc { get; set; }
        public DateTime? HlNgay1 { get; set; }
        public DateTime? HlNgay2 { get; set; }
        public string GhiChu { get; set; }
    }
}
