﻿using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Material
    {
        public long Id { get; set; }
        public string MaterialGroup { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Unit { get; set; }
    }
}
