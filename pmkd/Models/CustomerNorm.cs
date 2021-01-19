using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class CustomerNorm
    {
        public string Makhach { get; set; }
        public string Nhomhang { get; set; }
        public string Macn { get; set; }
        public decimal ValueNorm { get; set; }
        public decimal ValueDmgh { get; set; }
        public string Ghichu { get; set; }
        public string NguoiGd { get; set; }
        public string ChucvuNguoigd { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserModify { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? GdMua { get; set; }
        public bool? GdBan { get; set; }
    }
}
