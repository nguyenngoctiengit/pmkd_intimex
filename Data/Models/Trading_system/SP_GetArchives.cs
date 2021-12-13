using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class SP_GetArchives
    {
        [Key]
        public long ArchivesId { get; set; }
        public string ArchivesCode { get; set; }
        public string ArchivesName { get; set; }
        public string Contents { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserCreate { get; set; }
        public string UserCreateName { get; set; }
        public int DocCount { get; set; }
        public bool IsFinish { get; set; }
        public DateTime? DateClose { get; set; }
        public bool IsGiaoViec { get; set; }
        public string DateAssign { get; set; }
        public string DateFinishAssign { get; set; }
        public int ArchivesType { get; set; }
        public string StatusArchiver { get; set; }
        public string MaCN { get; set; }
        public long DepId { get; set; }
    }
}
