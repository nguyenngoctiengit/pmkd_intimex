using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class CanController : Controller
    {
        public tradingsystem_blContext _context;
        public CanController(tradingsystem_blContext context)
        {
            _context = context;
        }
        public IActionResult cantrongluong()
        {
            ViewBag.nhanvien = (from k in _context.Cans
                                select k.NhanVien).Distinct().ToList();
            ViewBag.baove = (from k in _context.Cans
                             select k.BaoVe).Distinct().ToList();
            ViewBag.thukho = (from k in _context.Cans
                              select k.ThuKho).Distinct().ToList();
            ViewBag.nguoilap = (from k in _context.Cans
                                select k.NguoiLap).Distinct().ToList();
            ViewBag.lanhdao = (from k in _context.Cans
                               select k.LanhDao).Distinct().ToList();
            ViewBag.stock = _context.Stocks.ToList();
            ViewBag.listcan = _context.Cans.ToList();
            return View("can");
        }
        public object GetCan(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.Cans.OrderBy(a => a.Xeptai1), loadOptions);
        }
        [HttpPost]
        [Route("can/can/updatetlin/{id?}")]
        public IActionResult updatetlin(Can can, string id)
        {
            var datetime = DateTime.Now;
            var item_return = _context.Cans.Where(a => a.SystemId == id).FirstOrDefault();
            if (can.TlIn != null)
            {
                if (item_return.TlIn == 0 || item_return.TlIn == null)
                {
                    item_return.TlIn = can.TlIn;
                    item_return.TimeIn = datetime.ToString("HH:mm");
                    item_return.DateIn = datetime.Date;
                }
                else if (item_return.TlIn != 0 || item_return.TlIn != null)
                {
                    item_return.TlOut = can.TlIn;
                    item_return.TimeOut = datetime.ToString("HH:mm");
                    item_return.DateIn = datetime.Date;

                }
                if ((item_return.TlIn != 0 || item_return.TlIn != null) && (item_return.TlOut != 0 || item_return != null))
                {
                    item_return.TlNet = Math.Abs(Convert.ToDecimal(item_return.TlIn - item_return.TlOut - item_return.TlBao));
                }
            }
            item_return.LaiXe = can.LaiXe;
            item_return.NguoiLap = can.NguoiLap;
            item_return.NhanVien = can.NhanVien;
            item_return.ThuKho = can.ThuKho;
            item_return.BaoVe = can.BaoVe;
            item_return.LanhDao = can.LanhDao;
            _context.Cans.Update(item_return);
            _context.SaveChanges();
            return RedirectToAction("cantrongluong");
        }
    }
}
