using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NkDmkhachHang
    {
        public string Makhach { get; set; }
        public string Tenkhach { get; set; }
        public string Diachi { get; set; }
        public string Masothue { get; set; }
        public string Dienthoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Loaikhach { get; set; }
        public string SoTkNh { get; set; }
        public string TenNh { get; set; }
        public string MaCn { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateEdit { get; set; }
        public string TrangThai { get; set; }
    }
}
