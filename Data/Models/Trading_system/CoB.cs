using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class CoB
    {
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string BillNo { get; set; }
        public string Shiper { get; set; }
        public string Consignee { get; set; }
        public string PreCarri { get; set; }
        public string Voy1 { get; set; }
        public string Vessel { get; set; }
        public string Voy2 { get; set; }
        public string Date { get; set; }
        public string PortLoad1 { get; set; }
        public string Delivery { get; set; }
        public string Bags { get; set; }
        public string Goods { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public string InvoiceNo { get; set; }
        public string TMarks { get; set; }
        public string Marks { get; set; }
        public bool Medit { get; set; }
        public DateTime DateVn { get; set; }
        public string Customs { get; set; }
        public string Country { get; set; }
        public string VcciDate { get; set; }
        public string Issued { get; set; }
        public string Dvt1 { get; set; }
        public string Dvt2 { get; set; }
        public DateTime? DateIv { get; set; }
        public string Bulk { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
