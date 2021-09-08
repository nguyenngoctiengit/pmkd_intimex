using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ArchivesFileAttach
    {
        public long Id { get; set; }
        public long ArchivesId { get; set; }
        public string FileAttach { get; set; }
        public string FileSource { get; set; }
    }
}
