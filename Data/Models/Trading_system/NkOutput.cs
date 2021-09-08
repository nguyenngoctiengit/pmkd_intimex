using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NkOutput
    {
        public string Macn { get; set; }
        public string SystemId { get; set; }
        public string Makhach { get; set; }
        public string Tenkhach { get; set; }
        public string Diachi { get; set; }
        public string Masothue { get; set; }
        public string SoHd { get; set; }
        public DateTime NgayHd { get; set; }
        public string Soseri { get; set; }
        public string HtTt { get; set; }
        public string MaTte { get; set; }
        public decimal Tygia { get; set; }
        public string Diengiai { get; set; }
        public decimal TongSl { get; set; }
        public decimal Tienhang { get; set; }
        public int Thuesuat { get; set; }
        public decimal Tienthue { get; set; }
        public decimal Tongtien { get; set; }
        public string LoaiHd { get; set; }
        public string Trangthai { get; set; }
        public string StBangchu { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime DateEdit { get; set; }
    }
}
