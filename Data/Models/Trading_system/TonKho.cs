using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TonKho
    {
        public long Id { get; set; }
        public int? MaKho { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Dvt { get; set; }
        public decimal? DauKy { get; set; }
        public decimal? NhapKho { get; set; }
        public decimal? XuatKho { get; set; }
        public decimal? XuatSx { get; set; }
        public decimal? NhapSx { get; set; }
        public decimal? TonCuoi { get; set; }
        public decimal? TonThucTe { get; set; }
        public decimal? DonGia { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? IsFinish { get; set; }
    }
}
