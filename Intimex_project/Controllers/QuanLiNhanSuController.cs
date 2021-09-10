using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class QuanLiNhanSuController : Controller
    {
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public QuanLiNhanSuController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult thongtinnhansu()
        {
            return View("thongtinnhansu");
        }
        [HttpGet]
        public object getCbnv(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.NsDmcbnvs, loadOptions);
        }
        [HttpGet]
        public object getHDLD(DataSourceLoadOptions loadOptions, string MaCbNv)
        {
            var item_return = from a in _context.NsHdlds
                                where a.MaCbNv == MaCbNv
                                select new
                                {
                                    a.Ident00,
                                    a.SoHd,
                                    a.LoaiHd,
                                    a.NgayBd,
                                    a.NgayKt,
                                    a.NgachLuong,
                                    a.LuongCb,
                                    a.NgayKy,
                                    a.PcQc,
                                    a.BacLuong,
                                    a.GhiChu,
                                    a.HsLuong,
                                };
            return DataSourceLoader.Load(item_return, loadOptions);
        }
        [HttpGet]
        public object getCVKN(DataSourceLoadOptions loadOptions, string MaCbNv)
        {
            var item_return = from a in _context.NsCdkns
                              where a.MaCbnv == MaCbNv
                              select new
                              {
                                  a.NgayBd,
                                  a.SoQdkn,
                                  a.NoiDungCd,
                                  a.TgBks,
                                  a.TgHdqt,
                                  a.CdHdqt,
                                  a.GhiChu,
                                  a.Id,
                              };
            return DataSourceLoader.Load(item_return, loadOptions);
        }
    }
}
