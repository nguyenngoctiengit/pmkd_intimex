using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Signer
    {
        public long Id { get; set; }
        public int Stt { get; set; }
        public string MaKhach { get; set; }
        public string Nguoiky { get; set; }
        public string Chucvu { get; set; }
        public string Uyquyen { get; set; }
        public bool? Visible { get; set; }
    }
}
