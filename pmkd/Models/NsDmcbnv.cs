using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDmcbnv
    {
        public int? Stt { get; set; }
        public string IdNs { get; set; }
        public string MaCbNv { get; set; }
        public string TenCbNv { get; set; }
        public string MaBp { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoCmnd { get; set; }
        public string DiaChi { get; set; }
        public string DcHn { get; set; }
        public string SoPhone { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string SoHc { get; set; }
        public DateTime? NgaycapHc { get; set; }
        public string NoicapHc { get; set; }
        public string Email { get; set; }
        public DateTime? NgayBegin { get; set; }
        public DateTime? NgayEnd { get; set; }
        public string Macn { get; set; }
        public string TenTat { get; set; }
        public bool? GioiTinh { get; set; }
        public bool? LanhDao { get; set; }
        public string ChucVu { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QuocTich { get; set; }
        public string Hinh { get; set; }
        public string NguyenQuan { get; set; }
        public string HandPhone { get; set; }
        public string MaSoThue { get; set; }
        public string TinhTrangHn { get; set; }
        public string NoiSinh { get; set; }
        public string TdVh { get; set; }
        public string TdHv { get; set; }
        public string TdNn { get; set; }
        public string TdTh { get; set; }
        public string CmNv { get; set; }
        public string CongViec { get; set; }
        public string MemberId { get; set; }
        public string Website { get; set; }
        public string SoTk { get; set; }
        public string NganHang { get; set; }
        public string BiDanh { get; set; }
        public bool? TrangThai { get; set; }
        public string LdNghiviec { get; set; }
        public string SoQdNv { get; set; }
        public string UserCreate { get; set; }
        public string UserEdit { get; set; }

        public virtual NsDmtd TdHvNavigation { get; set; }
        public virtual NsDmtd TdNnNavigation { get; set; }
        public virtual NsDmtd TdThNavigation { get; set; }
    }
}
