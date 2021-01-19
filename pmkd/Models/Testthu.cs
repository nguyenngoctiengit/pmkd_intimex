using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Testthu
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime? Ngay { get; set; }
        public bool? Loai { get; set; }
        public byte[] Timstam { get; set; }
    }
}
