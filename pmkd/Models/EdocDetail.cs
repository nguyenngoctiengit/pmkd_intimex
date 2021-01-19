using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class EdocDetail
    {
        public long Id { get; set; }
        public string IdEd { get; set; }
        public byte[] DocStored { get; set; }
        public string DocLocation { get; set; }
        public string DocName { get; set; }
    }
}
