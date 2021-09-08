using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class InputContract
    {
        public long InputContractId { get; set; }
        public string Macn { get; set; }
        public string EntNumber { get; set; }
        public string ContractDetailId { get; set; }
        public string ContractNumber { get; set; }
        public long InputDetailId { get; set; }
        public string InputNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public int BagNumber { get; set; }
        public double Quantity { get; set; }
        public DateTime EntDate { get; set; }
        public string UserCreate { get; set; }
        public string Note { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual InputDetailSx InputDetail { get; set; }
    }
}
