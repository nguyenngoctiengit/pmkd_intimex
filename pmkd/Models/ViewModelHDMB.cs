using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Models
{
    public class ViewModelHDMB
    {
        public PortfolioPayment portfolioPayment { get; set; }
        public Hdmb hdmb { get; set; }
        public KhachHang khachHang { get; set; }
        public Signer signer { get; set; }
        public Hanghoa hanghoa { get; set; }
        public CtHdmb ctHdmb { get; set; }
    }
}
