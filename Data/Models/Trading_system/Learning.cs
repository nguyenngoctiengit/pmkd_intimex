using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Learning
    {
        public int ActId { get; set; }
        public string ObjectId { get; set; }
        public string Action { get; set; }
        public string ActModule { get; set; }
        public string Sms { get; set; }
    }
}
