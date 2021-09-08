using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ProcessWasteDetail
    {
        public long ProcessWasteDetailId { get; set; }
        public string ProcessWasteEntNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public int SoBao { get; set; }
        public decimal Price { get; set; }

        public virtual ProcessWaste ProcessWasteEntNumberNavigation { get; set; }
    }
}
