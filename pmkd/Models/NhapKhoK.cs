﻿using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NhapKhoK
    {
        public NhapKhoK()
        {
            NhapKhoChiTietKs = new HashSet<NhapKhoChiTietK>();
        }

        public string Id { get; set; }
        public string SoPhieu { get; set; }
        public DateTime? NgayChungTu { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string NguoiGiao { get; set; }
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public int? LyDo { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsConfirm { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string AproveName { get; set; }
        public bool? Approve { get; set; }
        public bool? IsPrint { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Macn { get; set; }
        public string BangTinhId { get; set; }

        public virtual ICollection<NhapKhoChiTietK> NhapKhoChiTietKs { get; set; }
    }
}
