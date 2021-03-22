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
    }
}
