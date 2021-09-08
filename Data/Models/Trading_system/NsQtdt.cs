using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsQtdt
    {
        public int Id { get; set; }
        public string MaCbNv { get; set; }
        public string KhoaHoc { get; set; }
        public string TruongHoc { get; set; }
        public string VanBang { get; set; }
        public int? IdCm { get; set; }
        public int? IdBachoc { get; set; }
        public string DatLoai { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public bool? NoiDt { get; set; }
        public string GhiChu { get; set; }
    }
}
