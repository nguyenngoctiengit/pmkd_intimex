using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsCongtac
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayVe { get; set; }
        public string NoiCt { get; set; }
        public string NhiemVu { get; set; }
        public string GhiChu { get; set; }
    }
}
