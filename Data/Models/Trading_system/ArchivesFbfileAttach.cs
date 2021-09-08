using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ArchivesFbfileAttach
    {
        public long Id { get; set; }
        public long ArchivesFbid { get; set; }
        public string FileAttach { get; set; }
        public string FileSource { get; set; }
    }
}
