using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TyGium
    {
        public long Id { get; set; }
        public DateTime EntDate { get; set; }
        public decimal TyGia { get; set; }
    }
}
