using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Data.Models.SignalR
{
    public partial class UserBranch
    {
        [Key]
        public long UserBranchId { get; set; }
        public string UserName { get; set; }
        public string BranchId { get; set; }
    }
}
