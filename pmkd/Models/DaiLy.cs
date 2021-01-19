using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DaiLy
    {
        public long Id { get; set; }
        public string DaiLyName { get; set; }
        public string DaiLyFullName { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string GiayPhep { get; set; }
        public string Mst { get; set; }
        public int Loai { get; set; }
        public string Macn { get; set; }
        public string UserName { get; set; }
    }
}
