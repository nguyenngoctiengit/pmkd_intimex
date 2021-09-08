using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Bill
    {
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string Shiper { get; set; }
        public string Consignee { get; set; }
        public string Notify { get; set; }
        public string BodyBill1 { get; set; }
        public string BodyBill2 { get; set; }
        public string PreCarri { get; set; }
        public string Voy1 { get; set; }
        public string PortLoad1 { get; set; }
        public string Vessel { get; set; }
        public string Voy2 { get; set; }
        public string PortLoad2 { get; set; }
        public string PortDisch { get; set; }
        public string Delivery { get; set; }
        public string BillNo { get; set; }
        public string Date { get; set; }
        public string TMarks { get; set; }
        public string Marks { get; set; }
        public string Goods { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public decimal Bags { get; set; }
        public string Tally { get; set; }
        public string Customs { get; set; }
        public string Issue { get; set; }
        public string MainUnit { get; set; }
        public string SubUnit { get; set; }
        public string Bulk { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
