using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class EditReason
    {
        public long Id { get; set; }
        public string Reason { get; set; }
        public string FrmObject { get; set; }
    }
}
