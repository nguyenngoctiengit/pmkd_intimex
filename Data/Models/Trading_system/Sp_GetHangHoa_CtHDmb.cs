using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Sp_GetHangHoa_CtHDmb
    {
        [Key]
        public string mahang { get; set; }
        public string tenhang { get; set; }
        public string dvt { get; set; }
        public int vat { get; set; }
        public bool IsCheck { get; set; }
        public int TLGD { get; set; }
    }
}
