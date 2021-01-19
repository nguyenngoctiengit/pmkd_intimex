using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class InputStockSx
    {
        public InputStockSx()
        {
            InputDetailSxes = new HashSet<InputDetailSx>();
        }

        public long InputStockId { get; set; }
        public string Macn { get; set; }
        public int InputTypeId { get; set; }
        public string InputTypeName { get; set; }
        public int IsProduce { get; set; }
        public string Stock { get; set; }
        public string StockCode { get; set; }
        public string InputNumber { get; set; }
        public DateTime EntDate { get; set; }
        public string PersonName { get; set; }
        public string Note { get; set; }
        public bool StatusDestroy { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string DvGiao { get; set; }
        public string LenhNhap { get; set; }
        public bool IsConfirm { get; set; }
        public DateTime? DateConfirm { get; set; }
        public string UserConfirm { get; set; }
        public int NumPrint { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<InputDetailSx> InputDetailSxes { get; set; }
    }
}
