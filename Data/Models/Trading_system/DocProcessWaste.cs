using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class DocProcessWaste
    {
        public long Id { get; set; }
        public string ProcessWasteNumber { get; set; }
        public string DocId { get; set; }
    }
}
