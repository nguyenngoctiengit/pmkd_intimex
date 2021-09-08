using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class GroupBranch
    {
        public long Id { get; set; }
        public string Branch { get; set; }
        public string Nhom { get; set; }
        public string MatHang { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
