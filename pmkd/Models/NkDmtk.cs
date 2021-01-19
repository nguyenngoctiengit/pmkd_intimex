using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NkDmtk
    {
        public int Id { get; set; }
        public string Macn { get; set; }
        public string TkNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string DienGiai { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime DateEdit { get; set; }
    }
}
