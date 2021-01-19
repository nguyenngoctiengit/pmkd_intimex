using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Department
    {
        public long DepartmentId { get; set; }
        public string BranchId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? SttNs { get; set; }
    }
}
