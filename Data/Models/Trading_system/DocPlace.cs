using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class DocPlace
    {
        public long DocPlaceId { get; set; }
        public string DocPlaceCode { get; set; }
        public string DocPlaceName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
