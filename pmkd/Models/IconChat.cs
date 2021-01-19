using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class IconChat
    {
        public long IconChatId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Descript { get; set; }
        public byte[] Images { get; set; }
    }
}
