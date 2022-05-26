using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GetHdTraHang_HistoryHDMB
    {
        [Key]
        public string sohdmua { get; set; }
        public string ngayky { get; set; }
        public string ItemCode { get; set; }
        public decimal SLHD { get; set; }
        public int SoBaoHD { get; set; }
        public double SLGiao { get; set; }
        public int SoBao { get; set; }
        public string NgayGiaohang { get; set; }
        public string ten_khach { get; set; }
        public string NgayGiaoTrenHD { get; set; }
        public string systemref { get; set; }
    }
}
