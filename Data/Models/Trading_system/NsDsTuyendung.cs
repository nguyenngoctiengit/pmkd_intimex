using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsDsTuyendung
    {
        public string Id { get; set; }
        public string Macn { get; set; }
        public string MaUv { get; set; }
        public string TenUv { get; set; }
        public string DotTd { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string TtHn { get; set; }
        public string DiaChi { get; set; }
        public string TamTru { get; set; }
        public string SoCmnd { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string DienThoai { get; set; }
        public string DiDong { get; set; }
        public string Email { get; set; }
        public string QuocTich { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string ChuyenNganh { get; set; }
        public string TdNn { get; set; }
        public string TdTh { get; set; }
        public string TdHv { get; set; }
        public string CongViec { get; set; }
        public string KinhNghiem { get; set; }
        public DateTime NgayNop { get; set; }
        public decimal MlMm { get; set; }
        public decimal? ChieuCao { get; set; }
        public decimal? CanNang { get; set; }
        public string TtSk { get; set; }
        public string Hinh { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateEdit { get; set; }
    }
}
