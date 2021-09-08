using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class BagType
    {
        public int BagTypeId { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string NamePrint { get; set; }
    }
}
