using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class KeHoachNam
    {
        public long Id { get; set; }
        public string Madv { get; set; }
        public string Nhom { get; set; }
        public int ChiTieu { get; set; }
        public double SoKh { get; set; }
        public int Nam { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
