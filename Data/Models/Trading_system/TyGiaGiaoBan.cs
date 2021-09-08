using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TyGiaGiaoBan
    {
        public long Id { get; set; }
        public decimal TyGia { get; set; }
        public int Tuan { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
