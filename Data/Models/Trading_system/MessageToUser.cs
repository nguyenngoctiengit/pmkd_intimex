using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class MessageToUser
    {
        public string Username { get; set; }
        public decimal? MessageType { get; set; }
        public string Contens { get; set; }
        public DateTime? MessageDate { get; set; }
        public long Id { get; set; }
    }
}
