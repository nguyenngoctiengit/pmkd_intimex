using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models_StoredProcedure
{
    public class Sp_GetChungtu_HDBan_HistoryHDMB
    {
        [Key]
        public string id { get; set; }
        public string invoice { get; set; }
        public DateTime date_iv { get; set; }
        public string bill_no { get; set; }
        public DateTime date_bill { get; set; }
        public string LoaiIV { get; set; }
        public decimal NW { get; set; }
        public decimal GW { get; set; }
        public decimal Bag { get; set; }
        public decimal Amount { get; set; }
        public string cbuyer { get; set; }
        public string goods { get; set; }
        public string DocumentType { get; set; }
    }
}
