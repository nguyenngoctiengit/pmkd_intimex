using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetDocument_Archive
    {
        public string StyleName { get; set; }
        public string TypeName { get; set; }
        public string NumberSign { get; set; }
        public DateTime DocDate { get; set; }
        public string Contents { get; set; }
        [Key]
        public long DocId { get; set; }
    }
}
