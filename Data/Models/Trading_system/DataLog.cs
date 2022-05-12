using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public partial class DataLog
    {
        public string SystemId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string RecordId { get; set; }
        public string state { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserCreate { get; set; }
    }
}
