using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class InputDetailSx
    {
        public InputDetailSx()
        {
            InputContracts = new HashSet<InputContract>();
        }

        public long InputDetailId { get; set; }
        public long InputStockId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public int SoBao { get; set; }
        public double Gw { get; set; }
        public double TlBao { get; set; }
        public int LoaiBao { get; set; }
        public long Kcsid { get; set; }
        public string Kcsnumber { get; set; }
        public string TruckNumber { get; set; }
        public string Customer { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual InputStockSx InputStock { get; set; }
        public virtual ICollection<InputContract> InputContracts { get; set; }
    }
}
