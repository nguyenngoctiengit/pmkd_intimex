using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetDocCome
    {
        [Key]
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime? DateCome { get; set; }
        public string Contents { get; set; }
        public int DocLever { get; set; }
        public string NumberCome { get; set; }
        public int NumberOfPage { get; set; }
        public string NumberSign { get; set; }
        public long DocPlaceId { get; set; }
        public string Singer { get; set; }
        public string Note { get; set; }
        public long DocTypeId { get; set; }
        public string TypeCode { get; set; }
        public string DocLevelName { get; set; }
        public long DocStyleId { get; set; }
        public string StyleCode { get; set; }
        public string DocPlaceName { get; set; }
        public int IsChuyen { get; set; }
        public int IsPublic { get; set; }
    }
}
