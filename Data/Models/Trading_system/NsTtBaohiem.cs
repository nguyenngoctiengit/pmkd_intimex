using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsTtBaohiem
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public string SoBhxh { get; set; }
        public DateTime? NgaycapBhxh { get; set; }
        public DateTime? NgayKtBhxh { get; set; }
        public string NoicapBhxh { get; set; }
        public bool? TgBhtn { get; set; }
        public DateTime? NgayBhtn { get; set; }
        public string SoBhyt { get; set; }
        public string KcbTinh { get; set; }
        public string KcbBv { get; set; }
        public DateTime? NgaycapBhyt { get; set; }
        public DateTime? NgayKtBhyt { get; set; }
    }
}
