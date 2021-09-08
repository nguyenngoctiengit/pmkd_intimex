using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsDotTd
    {
        public int Id { get; set; }
        public string MaDot { get; set; }
        public string TenDotTd { get; set; }
        public DateTime NgayNhanHs { get; set; }
        public DateTime NgayChotHs { get; set; }
        public DateTime NgayPv { get; set; }
        public bool KtTd { get; set; }
    }
}
