using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class InputDetail
    {
        public string InputDetailId { get; set; }
        public string InputStockId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public int SoBao { get; set; }
        public decimal Price { get; set; }
        public byte[] TimeStamp { get; set; }
        public double Gw { get; set; }
        public int LoaiBao { get; set; }
        public string OriginailItemCode { get; set; }
        public long? Kcsid { get; set; }
    }
}
