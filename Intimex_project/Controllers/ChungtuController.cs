using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Public_class;
using Microsoft.AspNetCore.Http;
using DevExtreme.AspNet.Data;

namespace Intimex_project.Controllers
{
    public class ChungtuController : Controller
    {
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public IActionResult AddVoucher()
        {
            return View("AddVoucher");
        }
        [HttpGet]
        public async Task<IActionResult> GetChungtu(DataSourceLoadOptions loadOptions)
        {
            var ChungTu = _context.Hdmbs.Where(a => a.Trangthai != 2 && a.MuaBan == "BAN" && a.Macn == HttpContext.Session.GetString("UnitName")).Select(i => new {
                i.Ref,
                i.Sohd,
            }).OrderBy(a => a.Sohd);
            return Json(await DataSourceLoader.LoadAsync(ChungTu, loadOptions));
        }
    }
}
