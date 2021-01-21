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

        public object JsonRequestBehavior { get; private set; }

        public DanhmucController(tradingsystem_blContext context)
        {
            _context = context;
        }
/*        public JsonResult IsUserExists(string Mahang)
        {
            //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
            return Json(!_context.Hanghoas.Any(x => x.Mahang == Mahang), JsonRequestBehavior.AllowGet);
        }*/

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
            if (_context.Nhom_hang_hoas.Any(x => x.Manhom == nhh.Manhom))
            {
                TempData["alertMessage1"] = "Mã nhóm hàng bị trùng thành công";
                return RedirectToAction("nhomhanghoa");
            }    
            else
            {
                _context.Nhom_hang_hoas.Add(nhh);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm nhóm hàng thành công";
                return RedirectToAction("nhomhanghoa");
            }    

        }
        public IActionResult delete(string id)
        {
            var flag = false;
            var list_product = _context.Hanghoas.ToList();
            var list_nhomhang = _context.Nhom_hang_hoas.Where(a => a.Manhom == id).FirstOrDefault();
            foreach(var a in list_product)
            {
                if (a.MaNhom == list_nhomhang.Manhom)
                {
                    flag = true;
                }    
                if (flag == true)
                {
                    TempData["alertMessage1"] = "Không được xóa, nhóm hàng này đã chứa hàng hóa";
                    return RedirectToAction("nhomhanghoa");
                }    
                else
                {
                    _context.Nhom_hang_hoas.Remove(list_nhomhang);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Xóa nhóm hàng thành công";
                    return RedirectToAction("nhomhanghoa");
                }
                
            }
            return RedirectToAction("nhomhanghoa");
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
                    TempData["alertMessage1"] = "Không được xóa, hàng hóa có chứa trong hợp đồng";
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
            if (_context.Hanghoas.Any(a => a.Mahang == hanghoa.Mahang) || _context.Hanghoas.Any(a => a.Idhanghoa == hanghoa.Idhanghoa))
            {
                TempData["alertMessage1"] = "Mã hàng hóa hoặc ID hàng hóa bị trùng";
                return RedirectToAction("nhomhanghoa");
            }
            else
            {
                _context.Hanghoas.Add(hanghoa);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm hàng hóa thành công";
                return RedirectToAction("nhomhanghoa");
            }
            


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

            var flag = false;
            var list_product = _context.CtHdmbs.ToList();
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
                    TempData["alertMessage1"] = "Không được sửa, hàng hóa có chứa trong hợp đồng";
                    return RedirectToAction("nhomhanghoa");
                }
                else
                {
                    _context.Update(hh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "update thành công";
                    return RedirectToAction("nhomhanghoa");
                }
            }







            }
    }
}

