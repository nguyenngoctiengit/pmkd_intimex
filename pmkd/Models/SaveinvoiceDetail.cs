using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class SaveinvoiceDetail
    {
        public string SystemId { get; set; }
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
        public decimal Amount { get; set; }
        public decimal AmountVat { get; set; }
        public string Customer { get; set; }
        public string TrangThai { get; set; }
    }
}
