using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Notice
    {
        public long NoticeId { get; set; }
        public string Macn { get; set; }
        public DateTime EntDate { get; set; }
        public string UserName { get; set; }
        public string NoticeContent { get; set; }
        public string FileStore { get; set; }
        public string ImageStore { get; set; }
    }
}
