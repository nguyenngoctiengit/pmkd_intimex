using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GiaoNhan_HistoryHDMB
    {
        public string sohdmua { get; set; }
        public string sohdban { get; set; }
        public DateTime ngayky { get; set; }
        public string ItemCode { get; set; }
        public decimal SLHD { get; set; }
        public int SoBaoHD { get; set; }
        public decimal SLGiao { get; set; }
        public int SoBao { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public string ten_khach { get; set; }
        public DateTime NgayGiaoTrenHD { get; set; }
        public decimal Gia { get; set; }
        public string xe_vc { get; set; }
        public string NoiGiaoHang { get; set; }
        public string Id { get; set; }

    }
}
