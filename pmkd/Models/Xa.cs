using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Xa
    {
        public long Id { get; set; }
        public long HuyenId { get; set; }
        public string HuyenName { get; set; }
        public string Ten { get; set; }

        public virtual Huyen Huyen { get; set; }
    }
}
