using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class LenhCatChuyen
    {
        public int Id { get; set; }
        public string SoYeuCauKhach { get; set; }
        public string LenhCatChuyen1 { get; set; }
        public DateTime NgayLenh { get; set; }
        public DateTime DateCreate { get; set; }
        public string IdChungTuKemTheo { get; set; }
        public string GhiChu { get; set; }
    }
}
