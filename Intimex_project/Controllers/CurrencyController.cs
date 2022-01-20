using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class CurrencyController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public IActionResult Currency()
        {
            return View("Currency");
        }
        [HttpGet]
        public object GetCurrency(DataSourceLoadOptions loadOptions)
        {
            var item = _context.Dmttes.ToList().OrderByDescending(a => a.NgayAd);
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public IActionResult AddOrEditCurrency(long Id)
        {
            if (Id != null)
            {
                ViewBag.id = Id;
                var dmtte = _context.Dmttes.Where(a => a.Id == Id).FirstOrDefault();
                return PartialView("_PartiView_AddOrEdit_Currency", dmtte);
            }
            else
            {
                return PartialView("_PartiView_AddOrEdit_Currency");
            }
        }
        [HttpPost]
        public IActionResult AddOrEdit_Currency(long id, Dmtte dmtte)
        {
            if (id == 0 || id == null)
            {
                Dmtte dmtte1 = new Dmtte();
                dmtte1.MaTte = dmtte.MaTte;
                dmtte1.NgayAd = dmtte.NgayAd;
                dmtte1.Tyle = dmtte.Tyle;
                dmtte1.Tyle1 = dmtte.Tyle1;
                dmtte1.Tyle2 = dmtte.Tyle2;
                _context.Dmttes.Add(dmtte1);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm tiền tệ thành công";
                return RedirectToAction("Currency");
            }
            else
            {
                var dmtte1 = _context.Dmttes.FirstOrDefault(a => a.Id == id);
                dmtte1.MaTte = dmtte.MaTte;
                dmtte1.NgayAd = dmtte.NgayAd;
                dmtte1.Tyle = dmtte.Tyle;
                dmtte1.Tyle1 = dmtte.Tyle1;
                dmtte1.Tyle2 = dmtte.Tyle2;
                _context.Dmttes.Update(dmtte1);
                _context.SaveChanges();
                TempData["alertMessage"] = "Chỉnh sửa tiền tệ thành công";
                return RedirectToAction("Currency");
            }
        }
        public IActionResult Huyen()
        {
            return View("Huyen");
        }
        [HttpGet]
        public object GetHuyen(DataSourceLoadOptions loadOptions)
        {
            var item = _context.Huyens.ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpDelete]
        public void DeleteHuyen(int key)
        {
            var item = _context.Huyens.FirstOrDefault(a => a.Id == key);
            _context.Huyens.Remove(item);
            _context.SaveChanges();
        }
        public async Task<IActionResult> getkhuvuc(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Khuvucs.Where(a => a.Show4C == true).Select(i => new
            {
                i.Id,
                i.MaKhuvuc,
                i.TenKhuvuc
            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        [HttpPost]
        public IActionResult AddOrEditHuyen(int Id)
        {
            if (Id != 0)
            {
                ViewBag.id = Id;
                var huyen = _context.Huyens.Where(a => a.Id == Id).FirstOrDefault();
                return PartialView("_PartiView_AddOrEdit_Huyen", huyen);
            }
            else
            {
                return PartialView("_PartiView_AddOrEdit_Huyen");
            }
        }
        [HttpPost]
        public IActionResult AddOrEdit_Huyen(int id, Huyen huyen)
        {
            if (id == 0)
            {
                Huyen huyen1 = new Huyen();
                huyen1.KhuVucId = huyen.KhuVucId;
                huyen1.KhuVucName = _context.Khuvucs.Where(a => a.Id == huyen.KhuVucId).Select(a => a.TenKhuvuc).FirstOrDefault();
                huyen1.Ten = huyen.Ten;
                _context.Huyens.Add(huyen1);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm huyện thành công";
                return RedirectToAction("Huyen");
            }
            else
            {
                var huyen1 = _context.Huyens.FirstOrDefault(a => a.Id == id);
                huyen1.KhuVucId = huyen.KhuVucId;
                huyen1.KhuVucName = _context.Khuvucs.Where(a => a.Id == huyen.KhuVucId).Select(a => a.TenKhuvuc).FirstOrDefault();
                huyen1.Ten = huyen.Ten;
                _context.Huyens.Update(huyen1);
                _context.SaveChanges();
                TempData["alertMessage"] = "Chỉnh sửa huyện thành công";
                return RedirectToAction("Huyen");
            }
        }
    }
}
