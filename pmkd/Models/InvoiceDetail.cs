using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class InvoiceDetail
    {
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string SystemRef { get; set; }
        public string Sohd { get; set; }
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public decimal Bag { get; set; }
        public decimal UnitPrice { get; set; }
        public string Quanlity { get; set; }
        public string CachTinhGia { get; set; }
        public string PackedBy { get; set; }
        public string SohdVat { get; set; }
        public string SerialVat { get; set; }
        public DateTime? DateVat { get; set; }
        public decimal AmountVnd { get; set; }
        public string AmountByLetter { get; set; }
        public string Customer { get; set; }
        public string TinhStoploss { get; set; }
        public decimal MucStoploss { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
