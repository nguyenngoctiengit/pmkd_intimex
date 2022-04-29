using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Public_class
{
    public class DataLog
    {
        public string State { get; set; }
        public string TableName { get; set; }
        public string RecordId { get; set; }
        public string ColumnName { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
    }
}
