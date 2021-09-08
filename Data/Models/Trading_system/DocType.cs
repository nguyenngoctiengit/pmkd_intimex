using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class DocType
    {
        public long DocTypeId { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
    }
}
