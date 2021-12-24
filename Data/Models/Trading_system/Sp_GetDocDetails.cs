using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetDocDetails
    {
        [Key]
        public long DocId { get; set; }
        public string TypeCode { get; set; }
        public DateTime DocDate { get; set; }
        public string NumberSign { get; set; }
        public string StyleCode { get; set; }
        public string Contents { get; set; }
        public string DocLever { get; set; }
        public int NumDocProcess { get; set; }
        public int NumDocProcessIsView { get; set; }
        public string UserSend { get; set; }
        public int IsFeedBack { get; set; }


    }
}
