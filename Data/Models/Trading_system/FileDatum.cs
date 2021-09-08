using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class FileDatum
    {
        public Guid Id { get; set; }
        public string IdIndex { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
    }
}
