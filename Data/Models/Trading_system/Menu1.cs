using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Menu1
    {
        public double? Id { get; set; }
        public bool? IsSystem { get; set; }
        public double? BeginGroup { get; set; }
        public bool? NavExpand { get; set; }
        public double? IdBrother { get; set; }
        public string DescriptBrother { get; set; }
        public double? IdParent { get; set; }
        public bool? LagerIcon { get; set; }
        public string MenuName { get; set; }
        public string MenuNameE { get; set; }
        public string Event { get; set; }
        public string IconLager { get; set; }
        public string Icon { get; set; }
        public string Show { get; set; }
        public string Object { get; set; }
        public string Method { get; set; }
        public string Type { get; set; }
    }
}
