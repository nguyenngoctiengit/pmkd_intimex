using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NkDmhangHoa
    {
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Loaihang { get; set; }
        public string MaCn { get; set; }
        public string Dvt { get; set; }
        public string Quicach { get; set; }
        public decimal Giamua { get; set; }
        public decimal Giaban { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateEdit { get; set; }
    }
}
