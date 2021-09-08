using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class AutomaticValuesBranch
    {
        public string ObjectName { get; set; }
        public string Macn { get; set; }
        public string UserId { get; set; }
        public bool? IsUsed { get; set; }
        public bool IsReset { get; set; }
        public string PrefixOfDefaultValueForId { get; set; }
        public byte? LengthOfDefaultValueForId { get; set; }
        public string LastValueOfColumnId { get; set; }
        public string NextValueOfColumnId { get; set; }
        public string SerialOfVatBill { get; set; }
        public decimal? Price { get; set; }
        public string Payment { get; set; }
        public int? Vat { get; set; }
        public string Dvt { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MinQuantity { get; set; }
        public string Printer { get; set; }
    }
}
