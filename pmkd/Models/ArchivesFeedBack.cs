using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class ArchivesFeedBack
    {
        public long ArchivesFeedBackId { get; set; }
        public long ArchivesId { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string Contents { get; set; }
        public bool IsFinish { get; set; }
    }
}
