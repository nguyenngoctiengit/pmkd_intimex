using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Kdtv
    {
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string Shiper { get; set; }
        public string Consignee { get; set; }
        public string PreCarri { get; set; }
        public string Voy1 { get; set; }
        public string PortLoad1 { get; set; }
        public string Vessel { get; set; }
        public string Voy2 { get; set; }
        public string Delivery { get; set; }
        public string BillNo { get; set; }
        public string Date { get; set; }
        public string TMarks { get; set; }
        public string Marks { get; set; }
        public string Goods { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public decimal Bags { get; set; }
        public string Country { get; set; }
        public string Tenthuoc { get; set; }
        public string Nongdo { get; set; }
        public string Ngaykt { get; set; }
        public string Tbao { get; set; }
        public bool Medit { get; set; }
        public string Tg { get; set; }
        public string Xl { get; set; }
        public string TenKh { get; set; }
        public string PlaceOfIssue { get; set; }
        public string MainUnit { get; set; }
        public string SubUnit { get; set; }
        public string Bulk { get; set; }
        public string Declaration { get; set; }
        public string SoNo { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
