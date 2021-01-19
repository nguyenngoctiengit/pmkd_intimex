using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Thanhtoan
    {
        public long Id { get; set; }
        public string Stt { get; set; }
        public string MaCt { get; set; }
        public DateTime NgayCt { get; set; }
        public string SoCt { get; set; }
        public string DienGiai { get; set; }
        public string MaTte { get; set; }
        public decimal TyGia { get; set; }
        public string Tk { get; set; }
        public string MaDt { get; set; }
        public decimal TienTt { get; set; }
        public decimal TienTtNt { get; set; }
        public string Systemref { get; set; }
        public string MaDvcs { get; set; }
        public int Nam { get; set; }
    }
}
