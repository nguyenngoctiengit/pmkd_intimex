using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetArchivesFeedBack
    {
        [Key]
        public long ArchivesFeedBackId { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string Contents { get; set; }
        public int IsAttach { get; set; }
    }
}
