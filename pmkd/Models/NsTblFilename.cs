using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsTblFilename
    {
        public int Id { get; set; }
        public string TblnameCha { get; set; }
        public string FilenameCha { get; set; }
        public string TblnameCon { get; set; }
        public string FilenameCon { get; set; }
        public bool? IsUpdate { get; set; }
    }
}
