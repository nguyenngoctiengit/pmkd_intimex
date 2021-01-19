using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
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
