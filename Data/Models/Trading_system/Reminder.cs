using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Reminder
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int IdMenu { get; set; }
    }
}
