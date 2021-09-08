using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ChangeStock
    {
        public ChangeStock()
        {
            ChangeDetails = new HashSet<ChangeDetail>();
        }

        public long ChangeStockId { get; set; }
        public string ChangeStockNumber { get; set; }
        public DateTime EntDate { get; set; }
        public string StockCodeSource { get; set; }
        public string StockNameSource { get; set; }
        public string StockCodeTarget { get; set; }
        public string StockNameTarget { get; set; }
        public string LenhXuat { get; set; }
        public string Note { get; set; }
        public string Macn { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<ChangeDetail> ChangeDetails { get; set; }
    }
}
