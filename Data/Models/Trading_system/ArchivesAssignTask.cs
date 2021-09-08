using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ArchivesAssignTask
    {
        public long ArchivesAssignTaskId { get; set; }
        public long ArchivesId { get; set; }
        public DateTime DateAssign { get; set; }
        public string UserAssign { get; set; }
        public string UserAccept { get; set; }
        public long DepId { get; set; }
        public string Contents { get; set; }
        public int IsProcess { get; set; }
        public DateTime DateCreate { get; set; }
        public int IsFinish { get; set; }
        public DateTime? DateFinish { get; set; }
        public DateTime DateFinishAssign { get; set; }
        public string Note { get; set; }

        public virtual Archive Archives { get; set; }
    }
}
