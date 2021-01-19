using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class DocProcess
    {
        public long DocProcessId { get; set; }
        public string UserSend { get; set; }
        public long DocId { get; set; }
        public string ObjectProcess { get; set; }
        public string Command { get; set; }
        public DateTime? DateProcess { get; set; }
        public DateTime DateLimit { get; set; }
        public DateTime? DateReceive { get; set; }
        public int StatusProcess { get; set; }
        public int IsProcessReady { get; set; }
        public string NoteProcessReady { get; set; }
    }
}
