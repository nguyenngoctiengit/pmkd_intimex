using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class ProcessWaste
    {
        public ProcessWaste()
        {
            ProcessWasteDetails = new HashSet<ProcessWasteDetail>();
        }

        public string EntNumber { get; set; }
        public DateTime EntDate { get; set; }
        public string ReportAttach { get; set; }
        public string Note { get; set; }
        public string Macn { get; set; }
        public string UserName { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public bool IsRaise { get; set; }

        public virtual ICollection<ProcessWasteDetail> ProcessWasteDetails { get; set; }
    }
}
