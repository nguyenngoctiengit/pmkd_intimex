using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class EditReason
    {
        public long Id { get; set; }
        public string Reason { get; set; }
        public string FrmObject { get; set; }
    }
}
