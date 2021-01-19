using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class BagType
    {
        public int BagTypeId { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string NamePrint { get; set; }
    }
}
