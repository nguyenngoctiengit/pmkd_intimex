using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Archive
    {
        public Archive()
        {
            ArchivesAssignTasks = new HashSet<ArchivesAssignTask>();
        }

        public long ArchivesId { get; set; }
        public string ArchivesCode { get; set; }
        public string ArchivesName { get; set; }
        public string MaCn { get; set; }
        public string Contents { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateClose { get; set; }
        public bool IsFinish { get; set; }
        public int ArchivesType { get; set; }
        public long DepId { get; set; }

        public virtual ICollection<ArchivesAssignTask> ArchivesAssignTasks { get; set; }
    }
}
