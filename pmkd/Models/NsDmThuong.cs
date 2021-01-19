using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDmThuong
    {
        public string MaCn { get; set; }
        public string MaThuong { get; set; }
        public DateTime NgayThuong { get; set; }
        public string NoiDung { get; set; }
        public bool IsKey { get; set; }
    }
}
