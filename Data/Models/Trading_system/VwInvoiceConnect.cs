using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class VwInvoiceConnect
    {
        public string Shd { get; set; }
        public string Systemref { get; set; }
        public string Makhach { get; set; }
        public DateTime DateHd { get; set; }
        public string Cbuyer { get; set; }
        public string Buyer { get; set; }
        public string Goods { get; set; }
        public string Invoice { get; set; }
        public DateTime? DateIv { get; set; }
        public string Payment { get; set; }
        public string BillNo { get; set; }
        public DateTime DateBill { get; set; }
        public decimal Amount { get; set; }
        public decimal? Gia { get; set; }
        public decimal? SoLuong { get; set; }
        public string Macn { get; set; }
        public string Tokhai { get; set; }
    }
}
