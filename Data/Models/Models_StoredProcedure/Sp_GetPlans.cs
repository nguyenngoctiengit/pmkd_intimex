using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GetPlans
    {
        [Key]
        public string SystemId { get; set; }
        public string soPA { get; set; }
        public decimal Trongluong { get; set; }
        public double TLCanGhep { get; set; }
        public string dvt { get; set; }
    }
}
