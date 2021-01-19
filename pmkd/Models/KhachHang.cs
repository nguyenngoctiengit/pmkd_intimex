using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class KhachHang
    {
        public string Idkhach { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string TenFull { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string MaSoThue { get; set; }
        public string TaiKhoan { get; set; }
        public string NganHang { get; set; }
        public string GiayPhep { get; set; }
        public DateTime? NgayCap { get; set; }
        public string MaCn { get; set; }
        public string MatHang { get; set; }
        public bool? CheckItem { get; set; }
        public bool CheckTh { get; set; }
        public bool? GiaoDichMua { get; set; }
        public bool? ThanhToanMua { get; set; }
        public bool? GiaoDichBan { get; set; }
        public bool? ThanhToanBan { get; set; }
        public string GhiChu { get; set; }
        public int? GiaoDich { get; set; }
        public DateTime? DateActive { get; set; }
        public string MaKhuvuc { get; set; }
        public string TenQg { get; set; }
        public string ToaKinhTe { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Vanchuyen { get; set; }
        public string Bocxep { get; set; }
        public string LoaiKhach { get; set; }
        public string NguoiKy1 { get; set; }
        public string ChucVu1 { get; set; }
        public string UyQuyen1 { get; set; }
        public string NguoiKy2 { get; set; }
        public string ChucVu2 { get; set; }
        public string UyQuyen2 { get; set; }
        public bool? Visible { get; set; }
        public decimal Sanluong { get; set; }
        public decimal Dientich { get; set; }
        public string MaHd { get; set; }
    }
}
