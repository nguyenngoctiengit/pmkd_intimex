using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class SuKienUser
    {
        public long Id { get; set; }
        public string ActionId { get; set; }
        public string UserName { get; set; }
        public string Macn { get; set; }
        public DateTime EntDate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
