﻿using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class LookupController : Controller
    {
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public LookupController(tradingsystem_blContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Getnhomhang(DataSourceLoadOptions loadOptions)
        {
            var manhomhang = _context.Nhom_hang_hoas.Select(i => new {
                i.Manhom,
                i.TenNhom
            });

            return Json(await DataSourceLoader.LoadAsync(manhomhang, loadOptions));
        }
        [HttpGet]
        public async Task<IActionResult> getmakhach(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.KhachHangs.Select(i => new { i.Idkhach, i.MaKhach });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        [HttpGet]
        public IActionResult getquocgia(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Quocgia.ToList();
            return Json(item_return);
        }
        [HttpGet]
        public async Task<IActionResult> getdonvi(DataSourceLoadOptions loadOptions)
        {
            var manhomhang = _context.Branches.Select(i => new {
                i.Id,
                i.NameE
            });

            return Json(await DataSourceLoader.LoadAsync(manhomhang, loadOptions));
        }
        [HttpGet]
        public async Task<IActionResult> getpttt(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.PortfolioPayments.Select(i => new
            {
                i.Id,
                i.Matt,
                i.Mucung,
                i.TenTt
            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));

        }
        [HttpGet]
        public IActionResult getdiadiemgiaohang()
        {
            return Json(_context.HdmbGiaohangs.ToList());
        }
        public async Task<IActionResult> getkhachhang(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.KhachHangs.Select(i => new
            {
                i.MaKhach,
                i.TenKhach,
                i.TenFull

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> gethdmbchomuon(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").Select(i => new
            {
                i.Systemref,
                i.Ref,
                i.Sohd

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getintky(DataSourceLoadOptions loadOptions)
        {
            var unitname = HttpContext.Session.GetString("UnitName");
            var item_return = _context.Signers.Where(m => m.MaKhach == unitname).Select(i => new { 
            i.Id,
            i.MaKhach,
            i.Nguoiky,
            i.Stt,
            i.Chucvu
            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getkhachky(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Signers.Select(i => new
            {
                i.Id,
                i.MaKhach,
                i.Nguoiky,
                i.Stt,
                i.Chucvu

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getthanhtoan(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.PortfolioPayments.Select(i => new
            {
                i.Id,
                i.Matt,
                i.TenTt,
                i.Mucung
            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getkhuvuc(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Khuvucs.Select(i => new
            {
                i.MaKhuvuc,
                i.TenKhuvuc

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getloaibao(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.BagTypes.Select(i => new
            {
                i.BagTypeId,
                i.Name

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> gethanghoa(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Hanghoas.Select(i => new
            {
                i.Idhanghoa,
                i.Mahang,
                i.Tenhang,
                i.MaNhom

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> gethopdong(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Hdmbs.Select(i => new
            {
                i.Systemref,
                i.Sohd,
                i.Tenfull
            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getkhohang(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Stocks.Select(i => new
            {
                i.StockCode,
                i.StockName

            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public async Task<IActionResult> getxevc(DataSourceLoadOptions loadOptions)
        {
            var uniname = HttpContext.Session.GetString("UnitName");
            var item_return = from c in _context.Cans
                              join x in _context.XepTais on c.IdXepTai equals x.Id
                              where c.Macn == uniname && x.Aprove == 1 && x.Kcs == "" && c.TlNet != 0 
                              select new
                              {
                                  c.TruckNo,
                                  x.Mahang,
                                  x.Tenhang,
                                  x.MaKhach,
                                  x.KhachHang,
                                  x.CanId,
                                  x.BagTypeId,
                                  x.SoBao,
                                  x.TlBaobi,
                                  Tl_Net = (c.TlIn > 0 && c.TlOut > 0) ? c.TlNet : 0,
                                  x.Id,
                                  x.Ngaycan,
                                  ghi_chu = x.GhiChu + " " + (x.Status == 2 ? "Đạt thử nếm" : "Không đạt thử nếm"),
                                  x.KhoId
                              };
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
    }
}
