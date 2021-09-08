using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Edit
    {
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string Description { get; set; }
        public bool? Selected { get; set; }
        public string Reason { get; set; }
        public string AttDoc { get; set; }
        public string Press { get; set; }
        public long Id { get; set; }
    }
}
