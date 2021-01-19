using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsYcTuyendung
    {
        public long Id { get; set; }
        public string Macn { get; set; }
        public string SoYc { get; set; }
        public DateTime NgayYc { get; set; }
        public string MaBp { get; set; }
        public string ChucVu { get; set; }
        public string LydoTuyen { get; set; }
        public string DangNv { get; set; }
        public long SoLuong { get; set; }
        public DateTime NgayTd { get; set; }
        public string YcKhac { get; set; }
        public string LoaiCv { get; set; }
        public string GioiTinh { get; set; }
        public long NamKn { get; set; }
        public string BangCap { get; set; }
        public string ChuyenMon { get; set; }
        public string TruongHoc { get; set; }
        public string XepLoai { get; set; }
        public string TdTh { get; set; }
        public string TdNn { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime DateEdit { get; set; }
    }
}
