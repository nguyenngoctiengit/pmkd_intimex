using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Menu
    {
        public int ThuTu { get; set; }
        public int Id { get; set; }
        public int? IdParent { get; set; }
        public string MenuName { get; set; }
        public string MenuNameE { get; set; }
        public double? TypeMenu { get; set; }
        public string Event { get; set; }
        public string IconButton { get; set; }
        public string Icon { get; set; }
        public string Show { get; set; }
        public string Object { get; set; }
        public string Method { get; set; }
        public string Type { get; set; }
        public int TypeOfForm { get; set; }
    }
}
