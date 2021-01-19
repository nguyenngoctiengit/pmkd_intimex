using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DocFileAttach
    {
        public long Id { get; set; }
        public long DocId { get; set; }
        public string FileAttach { get; set; }
        public string FileSource { get; set; }
    }
}
