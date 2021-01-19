using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsTtBhyt
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public string SoBhyt { get; set; }
        public string KcbTinh { get; set; }
        public string KcbBv { get; set; }
        public string BacLuong { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public decimal TyleNopBh { get; set; }
        public bool? DongBhCk { get; set; }
    }
}
