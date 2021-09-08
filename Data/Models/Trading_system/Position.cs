using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Position
    {
        public long PositionId { get; set; }
        public string PositionCode { get; set; }
        public string PositionName { get; set; }
    }
}
