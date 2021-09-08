using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Ioform
    {
        public int IoformId { get; set; }
        public string IoformName { get; set; }
        public string Form { get; set; }
        public long Id { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
