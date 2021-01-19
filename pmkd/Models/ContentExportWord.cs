using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class ContentExportWord
    {
        public long Id { get; set; }
        public int ReportType { get; set; }
        public string Contents { get; set; }
        public double FontSize { get; set; }
        public bool FontBold { get; set; }
        public bool FontItalic { get; set; }
        public bool FontUnderline { get; set; }
        public int Alignment { get; set; }
        public int LeftIndent { get; set; }
        public int Indexs { get; set; }
        public string ListVariable { get; set; }
        public double LineSpacingAfter { get; set; }
    }
}
