using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class EdocDatum
    {
        public string IdEd { get; set; }
        public string Systemref { get; set; }
        public string Sohd { get; set; }
        public string SoPa { get; set; }
        public string Mucsua { get; set; }
        public string OldValue { get; set; }
        public string Idreason { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Macn { get; set; }
        public string TypeDoc { get; set; }
        public string CheckingBy { get; set; }
        public bool? DocStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MessgeIn { get; set; }
        public int DocStyle { get; set; }
    }
}
