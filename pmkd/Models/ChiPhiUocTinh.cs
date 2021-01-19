using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class ChiPhiUocTinh
    {
        public long Id { get; set; }
        public string MaNhom { get; set; }
        public decimal ChiPhi { get; set; }
        public string GhiChu { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
