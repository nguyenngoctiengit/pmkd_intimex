using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DocProcessWaste
    {
        public long Id { get; set; }
        public string ProcessWasteNumber { get; set; }
        public string DocId { get; set; }
    }
}
