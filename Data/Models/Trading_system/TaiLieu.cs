using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class TaiLieu
    {
        public TaiLieu()
        {
            FileTaiLieus = new HashSet<FileTaiLieu>();
        }

        public long Id { get; set; }
        public long ParentNode { get; set; }
        public string NodeName { get; set; }
        public long DepartmentId { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<FileTaiLieu> FileTaiLieus { get; set; }
    }
}
