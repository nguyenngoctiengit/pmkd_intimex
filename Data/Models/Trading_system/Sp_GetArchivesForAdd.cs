using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetArchivesForAdd
    {
        public int IsCheck { get; set; }
        [Key]
        public long ArchivesId { get; set; }
        public string ArchivesName { get; set; }
        public string ArchivesTypeArchives { get; set; }
        public string StatusArchives { get; set; }
    }
}
