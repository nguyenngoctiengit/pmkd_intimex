﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NsDmtd
    {
        public int Id { get; set; }
        public string MaTd { get; set; }
        public string DienGiai { get; set; }
        public int LoaiTd { get; set; }
        public int SttBc { get; set; }
    }
}