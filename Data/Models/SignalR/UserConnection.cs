using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.SignalR
{
    public partial class UserConnection
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ConnectionId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
