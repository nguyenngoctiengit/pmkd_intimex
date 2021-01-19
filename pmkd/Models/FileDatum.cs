using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class FileDatum
    {
        public Guid Id { get; set; }
        public string IdIndex { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
    }
}
