using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class AutomaticValue
    {
        public string ObjectName { get; set; }
        public string PrefixOfDefaultValueForId { get; set; }
        public byte? LengthOfDefaultValueForId { get; set; }
        public string LastValueOfColumnId { get; set; }
        public string DefaultValueForSelection { get; set; }
        public decimal? Minvalue { get; set; }
        public decimal? Minquantity { get; set; }
        public decimal? Price { get; set; }
        public string Dvt { get; set; }
    }
}
