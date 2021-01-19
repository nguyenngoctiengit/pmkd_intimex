using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class CoX
    {
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string BillNo { get; set; }
        public string Shiper { get; set; }
        public string Notify { get; set; }
        public string PreCarri { get; set; }
        public string Voy1 { get; set; }
        public string Vessel { get; set; }
        public string Voy2 { get; set; }
        public string PortLoad2 { get; set; }
        public string PortLoad1 { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public string Bags { get; set; }
        public string TMarks { get; set; }
        public string Marks { get; set; }
        public string Date { get; set; }
        public string Goods { get; set; }
        public string IcoNum { get; set; }
        public string PortDish { get; set; }
        public string ImpCountr { get; set; }
        public string TsmCoun { get; set; }
        public string Delivery { get; set; }
        public DateTime DateVn { get; set; }
        public bool Medit { get; set; }
        public string Customs { get; set; }
        public string CodeTau { get; set; }
        public string CodeIm { get; set; }
        public string CodeTsm { get; set; }
        public string CodeNoti { get; set; }
        public string VcciDate { get; set; }
        public string Issued { get; set; }
        public string Dvt1 { get; set; }
        public string Dvt2 { get; set; }
        public string Bulk { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
