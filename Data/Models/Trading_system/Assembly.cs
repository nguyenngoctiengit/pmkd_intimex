using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Assembly
    {
        public long Id { get; set; }
        public string AssemblyName { get; set; }
        public string AssemblyVersion { get; set; }
        public string AssemblyPath { get; set; }
        public string UpdatePath { get; set; }
    }
}
