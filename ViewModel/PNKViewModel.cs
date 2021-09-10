using Data.Models.Trading_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PNKViewModel
    {
        public XuatKho xk { get; set; }
        public XuatKhoChiTiet xktc { get; set; }
        public Can ca { get; set; }
        public XepTai xt { get; set; }
        public NhapKho nk { get; set; }
        public NhapKhoChiTiet nkct { get; set; }
    }
}
