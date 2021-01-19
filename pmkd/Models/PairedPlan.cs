using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class PairedPlan
    {
        public string PlansId { get; set; }
        public string ContracId { get; set; }
        public string SystemId { get; set; }
        public double Trongluong { get; set; }
        public string Dvt { get; set; }
        public string Macn { get; set; }
    }
}
