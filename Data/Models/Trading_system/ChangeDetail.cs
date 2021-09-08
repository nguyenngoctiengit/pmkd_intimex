using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ChangeDetail
    {
        public long ChangeDetailId { get; set; }
        public long ChangeStockId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public int BagType { get; set; }
        public int BagNumber { get; set; }
        public double Quantity { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ChangeStock ChangeStock { get; set; }
    }
}
