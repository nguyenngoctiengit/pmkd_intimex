using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Department
    {
        public long DepartmentId { get; set; }
        public string BranchId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? SttNs { get; set; }
        public string LdDepartment { get; set; }
    }
}
