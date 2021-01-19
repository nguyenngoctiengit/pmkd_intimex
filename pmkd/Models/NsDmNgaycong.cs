using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDmNgaycong
    {
        public string MaCn { get; set; }
        public int Nam { get; set; }
        public int Thang { get; set; }
        public decimal SoNgay { get; set; }
        public bool IsKey { get; set; }
        public bool? IsKeyCc { get; set; }
    }
}
