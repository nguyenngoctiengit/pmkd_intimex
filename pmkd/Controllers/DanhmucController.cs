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
            ViewBag.listproduct = _context.CtHdmbs.ToList();
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            return View(_context.Hanghoas.Where(a => a.MaNhom == id).ToList());

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
        public IActionResult deletehanghoa(string id)
        {
            
            var flag = false;
            var list_product = _context.CtHdmbs.ToList();
            var hh = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            {
                foreach (var a in list_product)
                {
                    if (a.Mahang == hh.Mahang)
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    TempData["alertMessage"] = "Không được xóa, hàng hóa có chứa trong hợp đồng";
                    return RedirectToAction("nhomhanghoa");
                }
                else
                {
                   
                    _context.Hanghoas.Remove(hh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Xóa hàng hóa thành công";
                    return RedirectToAction("nhomhanghoa");
                }
            }
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
            _context.Hanghoas.Add(hanghoa);
            _context.SaveChanges();
            TempData["alertMessage"] = "Thêm hàng hóa thành công";
            return RedirectToAction("nhomhanghoa");


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
            var aaa = _context.Hanghoas.FirstOrDefault(a => a.Idhanghoa == hh.Idhanghoa);
            _context.Hanghoas.Update(aaa);
            _context.SaveChanges();
            TempData["alertMessage"] = "Cập nhật hàng hóa thành công";
            return RedirectToAction("nhomhanghoa");
        }


    }
}
