using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class HdmbAnnex
    {
        public long Id { get; set; }
        public string Systemref { get; set; }
        public string Number { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayTao { get; set; }
        public string Path { get; set; }
        public string IntKy { get; set; }
        public string ClientKy { get; set; }
    }
}
