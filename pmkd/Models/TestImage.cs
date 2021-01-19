using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class TestImage
    {
        public long TestId { get; set; }
        public byte[] Image { get; set; }
    }
}
