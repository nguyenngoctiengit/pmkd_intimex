using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetDocFeedback
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateLimit { get; set; }
        [Key]
        public long DocFeedBackId { get; set; }
        public long DocFeedBackParentId { get; set; }
        public long DocProcessId { get; set; }
        public string Idea { get; set; }
        public int StatusFeedBack { get; set; }
        public string UserReceive { get; set; }
        public string UserSend { get; set; }
        public string BranchId { get; set; }
        public long DepartmentId { get; set; }

    }
}
