using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Bank
    {
        public string Id { get; set; }
        public string Contens { get; set; }
        public string Macn { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
