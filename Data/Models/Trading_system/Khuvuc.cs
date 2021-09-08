using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Khuvuc
    {
        public Khuvuc()
        {
            Huyens = new HashSet<Huyen>();
        }

        public long Id { get; set; }
        public string MaKhuvuc { get; set; }
        public string TenKhuvuc { get; set; }
        public bool Show4C { get; set; }

        public virtual ICollection<Huyen> Huyens { get; set; }
    }
}
