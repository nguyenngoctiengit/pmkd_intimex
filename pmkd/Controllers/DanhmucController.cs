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
using ServiceStack;

namespace pmkd.Controllers
{
    public class DanhmucController : Controller
    {
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public DanhmucController(tradingsystem_blContext context)
        {
            _context = context;
        }
        //Index
        public IActionResult Index()
        {
            return View();
        }
        //list nhóm hàng hóa
        public IActionResult nhomhanghoa()
        {
            return View(_context.Nhom_hang_hoas);
        }
        //list hàng hóa
        [HttpGet]
        public IActionResult hanghoa(string id)
        {
            ViewBag.listproduct = _context.CtHdmbs.ToList();
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            return View(_context.Hanghoas.Where(a => a.MaNhom == id).ToList());

        }
        //view thêm nhóm hàng hóa
        public IActionResult themnhomhang()
        {
            return View("themnhomhang");
        }
        //hàm thêm nhóm hàng hóa
        [HttpPost]
        public IActionResult themnhomhang(Nhom_hang_hoa nhh)
        {
            if (ModelState.IsValid)
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
            else
                return View("themnhomhang");

        }
        //xóa nhóm hàng hóa
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
        //xóa hàng hóa
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
        //view tạo hàng hóa
        public IActionResult createhanghoa()
        {
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            ViewBag._nhomhang = _context.Nhomhangs.ToList();
            return View("createhanghoa");
        }
        //hàm tạo hàng hóa
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
        //Chi tiết hàng hóa
        public IActionResult detailhanghoa(string id)
        {
            ViewBag._nhomhang = _context.Nhomhangs.ToList();
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            ViewBag._hanghoa = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            var detail = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            return View(detail);
        }
        //cập nhật hàng hóa
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
        public IActionResult khuvuc()
        {
            ViewBag.quocgia = (from a in _context.Quocgia
                             join b in _context.KhachHangs
                                on a.Name equals b.TenQg where a.Name != "VIETNAM" select a).Distinct();
            ViewBag.khuvuc = (from a in _context.Khuvucs 
                              join b in _context.KhachHangs 
                              on a.MaKhuvuc equals b.MaKhuvuc where b.TenQg == "VIETNAM" select a).Distinct();
            return View("khuvuc");
        }
        public IActionResult khachhang(string id)
        {
            ViewBag.khuvuc = (from a in _context.Khuvucs
                              join b in _context.KhachHangs
                              on a.MaKhuvuc equals b.MaKhuvuc
                              where b.TenQg == "VIETNAM"
                              select a).Distinct();
            ViewBag.quocgia = (from a in _context.Quocgia
                               join b in _context.KhachHangs
                                  on a.Name equals b.TenQg
                               where b.TenQg != "VIETNAM"
                               select a).Distinct();
            ViewBag.nullquocgia = _context.KhachHangs.Where(a => a.TenQg == "").ToList();
            ViewBag.nulltinhthanh = _context.KhachHangs.Where(a => a.TenQg == "VIETNAM" && a.MaKhuvuc == "").ToList();
            ViewBag.item = (from a in _context.KhachHangs where a.MaKhuvuc == id select a).Distinct();
            ViewBag.item1 = (from b in _context.KhachHangs where b.TenQg == id select b).Distinct(); 
            return View("khachhang");
        }
        public IActionResult detailKH(string id)
        {
            ViewBag.signer = from kh in _context.KhachHangs join sn in _context.Signers on kh.MaKhach equals sn.MaKhach where kh.Idkhach == id select sn;
            ViewBag.customerNorm = from a in _context.KhachHangs join b in _context.CustomerNorms on a.MaKhach equals b.Makhach where a.Idkhach == id select b;
            ViewBag.list_qg = _context.Quocgia.ToList();
            var ct_kh = _context.KhachHangs.Where(a => a.Idkhach == id).FirstOrDefault();
            return View(ct_kh);
        }
        public IActionResult themkhachhang()
        {
            ViewBag.khuvuc = _context.Khuvucs.ToList();
            ViewBag.list_qg = _context.Quocgia.ToList();
            return View("themkhachhang");
        }
        [HttpPost]
        public IActionResult themkhachhang(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                if (_context.KhachHangs.Any(a => a.Idkhach == kh.Idkhach) || _context.KhachHangs.Any(a => a.MaKhach == kh.MaKhach))
                {
                    TempData["alertMessage1"] = "Mã khách hàng hoặc ID khách hàng bị trùng";
                    return RedirectToAction("khuvuc");
                }
                else
                {
                    _context.KhachHangs.Add(kh);
                    _context.SaveChanges();

                    TempData["alertMessage"] = "thêm khách hàng thành công";
                    return RedirectToAction("khuvuc");
                }
            }
            else
            {
                ViewBag.khuvuc = _context.Khuvucs.ToList();
                ViewBag.list_qg = _context.Quocgia.ToList();
                return View("themkhachhang");
            }

        }
    }
}

