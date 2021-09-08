using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsDangKyPhep
    {
        public long Id { get; set; }
        public string Macn { get; set; }
        public string EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double NumDay { get; set; }
        public long TypePhepId { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }
    }
}
