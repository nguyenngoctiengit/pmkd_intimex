using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
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
