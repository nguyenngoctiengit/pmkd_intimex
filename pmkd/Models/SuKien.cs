using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class SuKien
    {
        public string Id { get; set; }
        public string Macn { get; set; }
        public string SuKien1 { get; set; }
        public string IdSuKien { get; set; }
        public DateTime ThoiGian { get; set; }
        public string Creater { get; set; }
        public int Style { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
