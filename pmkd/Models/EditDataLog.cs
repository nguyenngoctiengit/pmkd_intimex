using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class EditDataLog
    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public string KeyId { get; set; }
        public DateTime? EditDate { get; set; }
        public string Columns { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string EditPerson { get; set; }
        public int? TypeAction { get; set; }
        public string Macn { get; set; }
    }
}
