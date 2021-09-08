using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class OutputDetail
    {
        public string OutputDetailId { get; set; }
        public string OutputStockId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public string ItemCodeOutputReal { get; set; }
        public string ItemNameOutputReal { get; set; }
        public string UnitOutputReal { get; set; }
        public double Quantity { get; set; }
        public int SoBao { get; set; }
        public int LoaiBao { get; set; }
        public decimal Gw { get; set; }
        public decimal ChiPhi { get; set; }
        public long Kcsid { get; set; }
        public string Kcsnumber { get; set; }
        public double QuantityOutputReal { get; set; }
        public int SoBaoOutputReal { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual OutputStock OutputStock { get; set; }
    }
}
