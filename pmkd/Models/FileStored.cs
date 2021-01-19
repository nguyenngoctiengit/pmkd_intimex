using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class FileStored
    {
        public string IdIndex { get; set; }
        public string FileName { get; set; }
        public string Realname { get; set; }
        public string UserStored { get; set; }
        public DateTime DateStored { get; set; }
        public int IsClosed { get; set; }
        public int TypeOfDoc { get; set; }
        public int WeekOfYear { get; set; }
        public int Year { get; set; }
        public long Department { get; set; }
        public string Unit { get; set; }
    }
}
