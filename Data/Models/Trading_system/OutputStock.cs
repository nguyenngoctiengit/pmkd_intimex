using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class OutputStock
    {
        public OutputStock()
        {
            OutputDetails = new HashSet<OutputDetail>();
        }

        public string OutputStockId { get; set; }
        public string Macn { get; set; }
        public int OutputTypeId { get; set; }
        public string OutputTypeName { get; set; }
        public string Stock { get; set; }
        public string StockCode { get; set; }
        public string ContractId { get; set; }
        public string ContractNumber { get; set; }
        public string Collate { get; set; }
        public string CollateId { get; set; }
        public string OutputNumber { get; set; }
        public DateTime EntDate { get; set; }
        public string PersonName { get; set; }
        public string PlaceExchange { get; set; }
        public string Note { get; set; }
        public bool StatusDestroy { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ContractIdSource { get; set; }
        public int? IsProduce { get; set; }
        public string LenhXuat { get; set; }
        public string DvNhan { get; set; }
        public string XeVc { get; set; }
        public string CanId { get; set; }
        public bool IsConfirm { get; set; }
        public DateTime? DateConfirm { get; set; }
        public string UserConfirm { get; set; }
        public bool IsPrinted { get; set; }
        public int IsOuputTp { get; set; }
        public string SeriOutputTp { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<OutputDetail> OutputDetails { get; set; }
    }
}
