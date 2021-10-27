using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Public_class
{
    public class Notification
    {
        public int id { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message1 { get; set; }

        public string nguoiGui { get; set; }
        public DateTime? Date { get; set; }
    }
}
