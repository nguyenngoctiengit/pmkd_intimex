using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Branch
    {
        public string Id { get; set; }
        public string TitleDocument { get; set; }
        public string NameE { get; set; }
        public string NameV { get; set; }
        public string AddressE { get; set; }
        public string AddressV { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Icocode { get; set; }
        public string ToaKinhTe { get; set; }
        public string Mst { get; set; }
        public int UnitType { get; set; }
        public string NameBg { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
