using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace pmkd.Controllers
{
    public class DanhmucController : Controller
    {
        public IEnumerable<Hanghoa> hanghoas { get; set; }
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public DanhmucController (tradingsystem_blContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult nhomhanghoa()
        {
            return View(_context.Nhom_hang_hoas);
        }
        [HttpGet]
        public IActionResult hanghoa(string id)
        {
            var model = new danhmucModel();
            Hanghoa hanghoa = new Hanghoa();
            model._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            model._hanghoa = _context.Hanghoas.Where(a => a.MaNhom == id).ToList();
            return View(model);

        }
        public IActionResult themnhomhang()
        {
            return View("themnhomhang");
        }
        [HttpPost]
        public IActionResult themnhomhang(Nhom_hang_hoa nhh)
        {
            if (ModelState.IsValid)
            {
                _context.Nhom_hang_hoas.Add(nhh);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm nhóm hàng thành công";
                return RedirectToAction("nhomhanghoa");
            }
            else return View("themnhomhang");
        }
        public IActionResult delete(string id)
        {
            var nhh = _context.Nhom_hang_hoas.Where(a => a.Manhom == id).FirstOrDefault();
            _context.Nhom_hang_hoas.Remove(nhh);
            _context.SaveChanges();
            TempData["alertMessage"] = "Xóa nhóm hàng thành công";
            return RedirectToAction("nhomhanghoa");
        }
        public IActionResult deletehanghoa(string id)
        {
            var hh = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            _context.Hanghoas.Remove(hh);
            _context.SaveChanges();
            TempData["alertMessage"] = "Xóa hàng hóa thành công";
            return RedirectToAction("hanghoa");
        }
        public IActionResult createhanghoa()
        {
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            ViewBag._nhomhang = _context.Nhomhangs.ToList();
            return View("createhanghoa");
        }
        [HttpPost]
        public IActionResult createhanghoa(Hanghoa hanghoa)
        {
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            ViewBag._nhomhang = _context.Nhomhangs.ToList();

                _context.Hanghoas.Add(hanghoa);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm hàng hóa thành công";
                return RedirectToAction("hanghoa");
            

        }
        public IActionResult detailhanghoa(string id)
        {
            ViewBag._nhomhang = _context.Nhomhangs.ToList();
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            ViewBag._hanghoa = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            var detail = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            return View(detail);
        }
        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update_Post(Hanghoa hh)
        {
            _context.Hanghoas.Update(hh);
            _context.SaveChanges();
            return RedirectToAction("hanghoa");
        }
        [Route("aaa")]
        public IActionResult aaa()
        {
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            ViewBag._nhomhang = _context.Nhomhangs.ToList();
            return View();
        }


    }
}
