using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DocFeedBack
    {
        public long DocFeedBackId { get; set; }
        public long DocProcessId { get; set; }
        public string Idea { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateLimit { get; set; }
        public string UserSend { get; set; }
        public string UserReceive { get; set; }
        public int StatusFeedBack { get; set; }
        public int ViewFeedBack { get; set; }
        public long DocFeedBackParentId { get; set; }
    }
}
