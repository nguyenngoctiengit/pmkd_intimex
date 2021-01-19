using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsDmbp
    {
        public string MaBp { get; set; }
        public string TenBp { get; set; }
        public string MaBpCha { get; set; }
        public string SttBp { get; set; }
        public DateTime NgayBegin { get; set; }
        public DateTime NgayEnd { get; set; }
        public string MaData { get; set; }
        public bool NhCuoi { get; set; }
        public string CreateLog { get; set; }
        public string LastModifyLog { get; set; }
    }
}
