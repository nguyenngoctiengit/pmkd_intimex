using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class HopdongController : Controller
    {
        public DateTime NgayKy;
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public HopdongController(tradingsystem_blContext context)
        {
            _context = context;
        }
        //Index
        public IActionResult Index()
        {
            return View();
        }
        //View HDMB
        public IActionResult hdmb()
        {
            ViewBag.signer = _context.Signers.ToList();
            var startDay = new DateTime(2020, 01, 01);
            var endDay = new DateTime(2021, 12, 30);
            var hdmb = (from a in _context.Hdmbs join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id 
                        join c in _context.KhachHangs on a.Makhach equals c.MaKhach
                        where (a.Ngayky >= startDay) && (a.Ngayky <= endDay) 
                        select new ViewModelHDMB{ 
                            hdmb = a,portfolioPayment = b,khachHang = c
                        }).ToList().Distinct();
            ViewBag.mucung = (from a in _context.Hdmbs join b in _context.PortfolioPayments on a.Thanhtoan equals b.Matt select b.Mucung).FirstOrDefault();
            return View("hdmb",hdmb);
        }
        //View Chi tiết hợp đồng mua bán
        public IActionResult cthdmb(string id)
        {
            ViewBag.cthdmb = from a in _context.CtHdmbs
                             join b in _context.Hanghoas on a.Mahang equals b.Mahang
                             where a.Systemref == id
                             select new ViewModelHDMB
                             {
                                 ctHdmb = a,
                                 hanghoa = b
                             };
            var hdmb = (from a in _context.Hdmbs where a.Systemref == id select a).FirstOrDefault();
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            ViewBag.mucung = (from a in _context.Hdmbs
                              join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                              where a.Systemref == id
                              select b.Mucung).FirstOrDefault();
            return View("cthdmb", hdmb);
        }
        //view thêm hợp đồng
        public IActionResult themhopdong()
        {
            ViewBag.hh = _context.Hanghoas.ToList();
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            return View("themhopdong");
        }
        //function thêm hợp đồng và chi tiết hợp đồng
        [HttpPost]
        public IActionResult themhopdong(ViewModelHDMB viewModelHDMB)
        {

            var hdchomuon = (from a in _context.Hdmbs where a.MuaBan == "CMUON" select a).ToList();
            var phuongthucthanhtoan = (from a in _context.PortfolioPayments select a).ToList();
            viewModelHDMB.hdmb.Macn = HttpContext.Session.GetString("UnitName");
            viewModelHDMB.hdmb.Trangthai = 1;
            viewModelHDMB.hdmb.Nguoilam = HttpContext.Session.GetString("userId");
            foreach (var item in phuongthucthanhtoan)
            {
                if (item.Id == viewModelHDMB.hdmb.ThanhtoanId)
                {
                    viewModelHDMB.hdmb.Thanhtoan = (from a in _context.PortfolioPayments where viewModelHDMB.hdmb.ThanhtoanId == item.Id select a.Matt).FirstOrDefault();
                }
            }
            if (viewModelHDMB.hdmb.HdcmuonId == null)
            {
                viewModelHDMB.hdmb.HdcmuonId = "";
                viewModelHDMB.hdmb.SoHdcmuon = "";
            }
            else
            {
                foreach (var item in hdchomuon)
                {
                    if (item.Systemref == viewModelHDMB.hdmb.HdcmuonId)
                    {
                        viewModelHDMB.hdmb.HdcmuonId = item.Systemref;
                        viewModelHDMB.hdmb.SoHdcmuon = (from a in _context.Hdmbs where viewModelHDMB.hdmb.HdcmuonId == item.Systemref select a.Sohd).FirstOrDefault().ToString();
                    }
                }
            }
            viewModelHDMB.hdmb.TrangthaiGhep = true;
            viewModelHDMB.hdmb.Ngaylam = DateTime.Now;
            viewModelHDMB.ctHdmb.Systemref = viewModelHDMB.hdmb.Systemref;
            viewModelHDMB.ctHdmb.Ref = viewModelHDMB.hdmb.Systemref;
            _context.Hdmbs.Add(viewModelHDMB.hdmb);
            _context.CtHdmbs.Add(viewModelHDMB.ctHdmb);
            _context.SaveChanges();
            return RedirectToAction("hdmb");
        }
        //View thêm chi tiết hợp đồng outright
        public IActionResult addcthdoutright(string id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
            ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            return View("addcthdoutright");
        }
        //function thêm chi tiết hợp đồng outright
        [HttpPost]
        public IActionResult addcthdoutright1(CtHdmb ctHdmb,string id)
        {
            ViewBag.cthdmb = from a in _context.CtHdmbs
                             join b in _context.Hanghoas on a.Mahang equals b.Mahang
                             where a.Systemref == id
                             select new ViewModelHDMB
                             {
                                 ctHdmb = a,
                                 hanghoa = b
                             };
            var item_return = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            ViewBag.mucung = (from a in _context.Hdmbs
                              join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                              where a.Systemref == id
                              select b.Mucung).FirstOrDefault();
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm chi tiết hợp đồng thành công";
            return View("cthdmb", item_return);
        }
        //View cập nhật chi tiết hợp đồng outright
        public IActionResult updatecthdoutright(long id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs
                                join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                                where b.Id == id
                                select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs
                             join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                             where b.Id == id
                             select a.Ref).FirstOrDefault().Trim();
            ViewBag.sohd = (from a in _context.Hdmbs
                            join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                            where b.Id == id
                            select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            var cthdmb = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            return View("updatecthdoutright",cthdmb);
        }
        //function cập nhật chi tiết hợp đồng outright
        [HttpPost]
        public IActionResult updatecthdoutright1(long id,CtHdmb ctHdmb)
        {
            var systemref = (from a in _context.CtHdmbs 
                             join b in _context.Hdmbs on a.Systemref equals b.Systemref where a.Id == id 
                             select a.Systemref).FirstOrDefault();
            ViewBag.cthdmb = from a in _context.CtHdmbs
                             join b in _context.Hanghoas on a.Mahang equals b.Mahang
                             where a.Systemref == systemref
                             select new ViewModelHDMB
                             {
                                 ctHdmb = a,
                                 hanghoa = b
                             };
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            ViewBag.mucung = (from a in _context.Hdmbs
                              join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                              join c in _context.CtHdmbs on a.Systemref equals c.Systemref
                              where  c.Id == id
                              select b.Mucung).FirstOrDefault();
            ctHdmb.Giatt = 0;
            _context.CtHdmbs.Update(ctHdmb);
            _context.SaveChanges();
            var return_item = (from a in _context.CtHdmbs join b in _context.Hdmbs on a.Systemref equals b.Systemref where a.Id == id select b).FirstOrDefault();
            TempData["alertMessage"] = "update chi tiết hợp đồng thành công";
            return View("cthdmb",return_item);
        }
        //xóa hợp đồng
        public IActionResult deletehopdong(string id)
        {
            var flag_stock = false;
            var flag_fix = false;
            var list_stock = _context.InputStocks.ToList();
            var list_fix = _context.Fixgia.ToList();
            var hh = (from a in _context.Hdmbs where a.Systemref == id select a).FirstOrDefault();
            foreach (var item in list_stock)
            {
                if (item.ContractId == hh.Systemref)
                {
                    flag_stock = true;
                }
            }
            foreach(var item in list_fix)
            {
                if (item.Systemref == hh.Systemref)
                {
                    flag_fix = true;
                }
            }
            if (flag_stock == true)
            {
                TempData["alertMessage"] = "hợp đồng đã giao hàng, không hủy đc";
                return RedirectToAction("hdmb");
            }
            if (flag_fix == true)
            {
                TempData["alertMessage"] = "hợp đồng đã fix giá, không hủy đc";
                return RedirectToAction("hdmb");
            }
            hh.Trangthai = 2;
            _context.Hdmbs.Update(hh);
            _context.SaveChanges();
            TempData["alertMessage"] = "xóa thành công";
            return RedirectToAction("hdmb");
        }
        //function cập nhật hợp đồng
        public IActionResult edithopdong(string id,Hdmb hdmb)
        {
            var hdchomuon = (from a in _context.Hdmbs where a.MuaBan == "CMUON" select a).ToList();
            if (hdmb.HdcmuonId == null)
            {
                hdmb.HdcmuonId = "";
                hdmb.SoHdcmuon = "";
            }
            else
            {
                foreach (var item in hdchomuon)
                {
                    if (item.Systemref == hdmb.HdcmuonId)
                    {
                        hdmb.HdcmuonId = item.Systemref;
                        hdmb.SoHdcmuon = (from a in _context.Hdmbs where hdmb.HdcmuonId == item.Systemref select a.Sohd).FirstOrDefault().ToString();
                    }
                }
            }
            hdmb.Macn = HttpContext.Session.GetString("UnitName");
            hdmb.TrangthaiGhep = true;
            _context.Update(hdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "cập nhật hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        //function xóa chi tiết hợp đồng
        public IActionResult deletecthd(long id)
        {
           
            var del_item = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            var flag_fix = false;
            var list_fix = _context.Fixgia.ToList();
            if (del_item != null)
            {
                foreach (var item in list_fix)
                {
                    if (del_item.Systemref == item.Systemref)
                    {
                        flag_fix = true;
                    }
                }
            }
            if (flag_fix == true)
            {
                var systemref = (from a in _context.CtHdmbs
                                 join b in _context.Hdmbs on a.Systemref equals b.Systemref
                                 where a.Id == id
                                 select a.Systemref).FirstOrDefault();
                ViewBag.cthdmb = from a in _context.CtHdmbs
                                 join b in _context.Hanghoas on a.Mahang equals b.Mahang
                                 where a.Systemref == systemref
                                 select new ViewModelHDMB
                                 {
                                     ctHdmb = a,
                                     hanghoa = b
                                 };
                ViewBag.kh = _context.KhachHangs.ToList();
                var uniname = HttpContext.Session.GetString("UnitName");
                ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
                ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
                ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
                ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
                ViewBag.client = _context.Signers.ToList();
                ViewBag.mucung = (from a in _context.Hdmbs
                                  join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                                  join c in _context.CtHdmbs on a.Systemref equals c.Systemref
                                  where c.Id == id
                                  select b.Mucung).FirstOrDefault();
                var item_return = (from a in _context.CtHdmbs join b in _context.Hdmbs on a.Systemref equals b.Systemref where a.Id == id select b).FirstOrDefault();
                TempData["alertMessage"] = "hợp đồng đã fix giá, không xóa đc";
                return View("cthdmb", item_return);

            }
            else
            {
                var systemref = (from a in _context.CtHdmbs
                                 join b in _context.Hdmbs on a.Systemref equals b.Systemref
                                 where a.Id == id
                                 select a.Systemref).FirstOrDefault();
                ViewBag.cthdmb = from a in _context.CtHdmbs
                                 join b in _context.Hanghoas on a.Mahang equals b.Mahang
                                 where a.Systemref == systemref
                                 select new ViewModelHDMB
                                 {
                                     ctHdmb = a,
                                     hanghoa = b
                                 };
                ViewBag.kh = _context.KhachHangs.ToList();
                var uniname = HttpContext.Session.GetString("UnitName");
                ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
                ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
                ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
                ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
                ViewBag.client = _context.Signers.ToList();
                ViewBag.mucung = (from a in _context.Hdmbs
                                  join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                                  join c in _context.CtHdmbs on a.Systemref equals c.Systemref
                                  where c.Id == id
                                  select b.Mucung).FirstOrDefault();
                var item_return = (from a in _context.CtHdmbs join b in _context.Hdmbs on a.Systemref equals b.Systemref where a.Id == id select b).FirstOrDefault();
                _context.CtHdmbs.Remove(del_item);
                _context.SaveChanges();
                TempData["alertMessage"] = "xóa chi tiết hợp đồng mua bán thành công";
                return View("cthdmb",item_return);
            }
        }
        //View thêm chi tiết hợp đồng
        public IActionResult addcthd(string id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault().Trim();
            ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            return View("addcthd");
        }
        [HttpPost]
        //function thêm chi tiết hợp đồng
        public IActionResult addcthd(string id,CtHdmb ctHdmb)
        {
            int t = 0;
            if (ctHdmb.FNgayfix == null)
            {
                ctHdmb.FNgayfix = new DateTime(1990, 01, 01);
            }
            if (int.TryParse(ctHdmb.Stoploss.ToString(), out t) == false && t < 0)
            {
                ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
                ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
                ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
                ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
                ViewBag.hanghoa = (from a in _context.Hanghoas select a).ToArray();
                TempData["alertMessage"] = "stop loss nhập không đúng";
                return View("themcthd");
            }
            if (ctHdmb.Giathang != "1" && ctHdmb.Giathang != "3" && ctHdmb.Giathang != "5" && ctHdmb.Giathang != "7" && ctHdmb.Giathang != "9" && ctHdmb.Giathang != "11")
            {
                ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
                ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
                ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
                ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
                ViewBag.hanghoa = (from a in _context.Hanghoas select a).ToArray();
                TempData["alertMessage"] = "giá tháng nhập không đúng";
                return View("themcthd");
            }
            if (int.TryParse(ctHdmb.Gianam, out t) == false && t < NgayKy.Year)
            {
                ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
                ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
                ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
                ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
                ViewBag.hanghoa = (from a in _context.Hanghoas select a).ToArray();
                TempData["alertMessage"] = "giá năm nhập không đúng";
                return View("themcthd");
            }
            if (ctHdmb.FNgayfix.Value.Year > t || (ctHdmb.FNgayfix.Value.Month > int.Parse(ctHdmb.Giathang) && ctHdmb.FNgayfix.Value.Year == t))
            {
                ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
                ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
                ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
                ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
                ViewBag.hanghoa = (from a in _context.Hanghoas select a).ToArray();
                TempData["alertMessage"] = "ngày chốt cuối nhập không đúng";
                return View("themcthd");
            }
            ctHdmb.Dvt = "KGS";
            ViewBag.cthdmb = from a in _context.CtHdmbs
                             join b in _context.Hanghoas on a.Mahang equals b.Mahang
                             where a.Systemref == id
                             select new ViewModelHDMB
                             {
                                 ctHdmb = a,
                                 hanghoa = b
                             };
            var item_return = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            ViewBag.mucung = (from a in _context.Hdmbs
                              join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                              where a.Systemref == id
                              select b.Mucung).FirstOrDefault();
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm chi tiết hợp đồng thành công";
            return View("cthdmb", item_return);
        }
        public IActionResult updatecthd(long id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs
                                join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                                where b.Id == id
                                select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs
                             join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                             where b.Id == id
                             select a.Ref).FirstOrDefault().Trim();
            ViewBag.sohd = (from a in _context.Hdmbs
                            join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                            where b.Id == id
                            select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            var cthdmb = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            return View("updatecthd", cthdmb);
        }
        public IActionResult updatecthd(CtHdmb ctHdmb,string id)
        {
            ctHdmb.Giact = 0;
            ctHdmb.Dvt = "KGS";
            ctHdmb.Giatt = 0;
            ctHdmb.DvtTheoHd = "KGS";
            _context.Update(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "cập nhật chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
    }
}
