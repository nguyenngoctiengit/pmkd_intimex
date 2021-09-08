using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ContSea
    {
        public long Id { get; set; }
        public string InvoiceId { get; set; }
        public string Customs { get; set; }
        public string MaHang { get; set; }
        public string Dvt { get; set; }
        public string ContNo { get; set; }
        public string SealNo { get; set; }
        public decimal Nw { get; set; }
        public decimal Gw { get; set; }
        public string PackedBy { get; set; }
        public decimal Bags { get; set; }
        public decimal Tear { get; set; }
        public string Bulk { get; set; }
    }
}
