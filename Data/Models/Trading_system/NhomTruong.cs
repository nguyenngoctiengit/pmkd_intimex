using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NhomTruong
    {
        public long Id { get; set; }
        public string NhomTruongName { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string GiayPhep { get; set; }
    }
}
