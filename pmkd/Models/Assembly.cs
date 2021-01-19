using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
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
