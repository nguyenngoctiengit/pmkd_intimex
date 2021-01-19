using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class XuatKho
    {
        public XuatKho()
        {
            XuatKhoChiTiets = new HashSet<XuatKhoChiTiet>();
        }

        public string Id { get; set; }
        public string SoPhieu { get; set; }
        public string RsoPhieu { get; set; }
        public DateTime NgayChungTu { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string NguoiNhan { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public int LyDo { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? IsConfirm { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string AproveName { get; set; }
        public bool Approve { get; set; }
        public bool? IsPrint { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Macn { get; set; }
        public string NguoiMuaF { get; set; }
        public string LenhXk { get; set; }

        public virtual ICollection<XuatKhoChiTiet> XuatKhoChiTiets { get; set; }
    }
}
