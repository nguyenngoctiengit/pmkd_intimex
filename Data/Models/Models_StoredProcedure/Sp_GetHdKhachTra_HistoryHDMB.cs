using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GetHdKhachTra_HistoryHDMB
    {
        public string ref_hdmb { get; set; }
        public string sohd { get; set; }
        public string ngayky { get; set; }
        public decimal SLHD { get; set; }
        public int SoBaoHD { get; set; }
        public string ten_khach { get; set; }
        public string NgayGiao { get; set; }
        public double SLGiao { get; set; }
        public int SoBaoGiao { get; set; }
        public string mahang { get; set; }
        [Key]
        public string systemref { get; set; }
    }
}
