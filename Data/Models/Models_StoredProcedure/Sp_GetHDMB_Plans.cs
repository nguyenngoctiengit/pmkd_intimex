using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GetHDMB_Plans
    {
        [Key]
        public string systemref { get; set; }
        public string sohd { get; set; }
        public string makhach { get; set; }
        public double TrongluongHD { get; set; }
        public double TrongLuongDuocGhep { get; set; }
    }
}
