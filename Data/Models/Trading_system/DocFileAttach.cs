using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class DocFileAttach
    {
        public long Id { get; set; }
        public long DocId { get; set; }
        public string FileAttach { get; set; }
        public string FileSource { get; set; }
    }
}
