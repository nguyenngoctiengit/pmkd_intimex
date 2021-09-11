using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Sex { get; set; }
        public long BirthPlace { get; set; }
        public long NativeCountry { get; set; }
        public DateTime DateWorking { get; set; }
        public long Position { get; set; }
        public long Department { get; set; }
        public string Branch { get; set; }
    }
}
