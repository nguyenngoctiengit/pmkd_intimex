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
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public HopdongController(tradingsystem_blContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
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
            return View("cthdmb", hdmb);
        }
        /*        public IActionResult cthdmb(string id)
                {
                    ViewBag.signer = _context.Signers.ToList();
                    var startDay = new DateTime(2020, 01, 01);
                    var endDay = new DateTime(2021, 12, 30);
                    var cthdmb = (from a in _context.Hdmbs
                                join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                                join c in _context.KhachHangs on a.Makhach equals c.MaKhach
                                where (a.Ngayky >= startDay) && (a.Ngayky <= endDay)
                                select new ViewModelHDMB
                                {
                                    hdmb = a,
                                    portfolioPayment = b,
                                    khachHang = c
                                }).ToList().Distinct();
                    ViewBag.cthdmb = from a in _context.CtHdmbs
                                     join b in _context.Hanghoas on a.Mahang equals b.Mahang
                                     where a.Systemref == id
                                     select new ViewModelHDMB
                                     {
                                         ctHdmb = a,hanghoa = b
                                     };
                    return View("cthdmb",cthdmb);
                }*/
        public IActionResult themhopdong()
        {
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            return View("themhopdong");
        }
        [HttpPost]
        public IActionResult themhopdong(Hdmb hdmb1)
        {

            var hdchomuon = (from a in _context.Hdmbs where a.MuaBan == "CMUON" select a).ToList();
            var phuongthucthanhtoan = (from a in _context.PortfolioPayments select a).ToList();
            hdmb1.Macn = HttpContext.Session.GetString("UnitName");
            hdmb1.Trangthai = 1;
            hdmb1.Nguoilam = HttpContext.Session.GetString("userId");
            foreach(var item in phuongthucthanhtoan)
            {
                if (item.Id == hdmb1.ThanhtoanId)
                {
                    hdmb1.Thanhtoan = (from a in _context.PortfolioPayments where hdmb1.ThanhtoanId == item.Id select a.Matt).FirstOrDefault();
                }    
            }    
            if (hdmb1.HdcmuonId == null)
            {
                hdmb1.HdcmuonId = "";
                hdmb1.SoHdcmuon = "";
            }
            else
            {
                foreach (var item in hdchomuon)
                {
                    if (item.Systemref == hdmb1.HdcmuonId)
                    {
                        hdmb1.HdcmuonId = item.Systemref;
                        hdmb1.SoHdcmuon = (from a in _context.Hdmbs where hdmb1.HdcmuonId == item.Systemref select a.Sohd).FirstOrDefault().ToString();
                    }
                }
            }
            hdmb1.TrangthaiGhep = true;
            hdmb1.Ngaylam = DateTime.Now;
            _context.Hdmbs.Add(hdmb1);
            _context.SaveChanges();
            var startDay = new DateTime(2020, 01, 01);
            var endDay = new DateTime(2021, 12, 30);
            var hdmb = (from a in _context.Hdmbs
                        join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id
                        join c in _context.KhachHangs on a.Makhach equals c.MaKhach
                        where (a.Ngayky >= startDay) && (a.Ngayky <= endDay)
                        select new ViewModelHDMB
                        {
                            hdmb = a,
                            portfolioPayment = b,
                            khachHang = c
                        }).ToList().Distinct();
            TempData["alertMessage"] = "thêm người hợp đồng thành công";
            return RedirectToAction("hdmb");
        }     
        public IActionResult themcthdoutright(string id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
            ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            ViewBag.hanghoa = (from a in _context.Hanghoas select a).ToArray();
            return View("themcthdoutright");
        }
        [HttpPost]
        public IActionResult themcthdoutright(CtHdmb ctHdmb, string id)
        {
            ctHdmb.IdRow = null;
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        public IActionResult themcthd(string id)
        {
            return View("themcthd");
        }

    }
}
