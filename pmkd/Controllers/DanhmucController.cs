﻿using Microsoft.AspNetCore.Mvc;
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
using RouteAttribute = ServiceStack.RouteAttribute;
using System.Web;

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
        
        //list hàng hóa
        //===============================================Hàng hóa===========================================
        [HttpGet]
        public IActionResult hanghoa(string id)
        {
            ViewBag.cthdmb = _context.CtHdmbs.ToList();
            return View("hanghoa/hanghoa",_context.Hanghoas.Where(a => a.Visible == true).ToList());

        }
        //view thêm nhóm hàng hóa
        public IActionResult themnhomhang()
        {
            return View("hanghoa/themnhomhang");
        }
        //hàm thêm nhóm hàng hóa
        [HttpPost]
        public IActionResult themnhomhang(Nhom_hang_hoa nhh)
        {
            if (ModelState.IsValid)
            {
                if (_context.Nhom_hang_hoas.Any(x => x.Manhom == nhh.Manhom))
                {
                    TempData["alertMessage1"] = "Mã nhóm hàng bị trùng, không thể thêm, mời nhập lại";
                    return RedirectToAction("hanghoa/hanghoa");
                }
                else
                {
                    _context.Nhom_hang_hoas.Add(nhh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Thêm nhóm hàng thành công";
                    return RedirectToAction("hanghoa/hanghoa");
                }
            }
            else
                return View("hanghoa/themnhomhang");

        }
        public IActionResult updateHH(string id)
        {
            ViewBag._hanghoa = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();    
            ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            var item = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
            return View("hanghoa/updateHH",item);
        }
        [HttpPost]
        public IActionResult updateHH(Hanghoa hanghoa,string id)
        {
            if (ModelState.IsValid)
            {
                _context.Update(hanghoa);
                _context.SaveChanges();
                TempData["alertMessage"] = "update thành công";
                return RedirectToAction("hanghoa/hanghoa");
            }   
            else
            {
                ViewBag._hanghoa = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
                ViewBag._nhomhanghoa = _context.Nhom_hang_hoas.ToList();
                return View("hanghoa/updateHH");
            }    
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
                    return RedirectToAction("hanghoa");
                }
                else
                {
                    hh.Visible = false;
                    hh.Sudung = 0;
                    _context.Hanghoas.Update(hh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Xóa hàng hóa thành công";
                    return RedirectToAction("hanghoa");
                }
            }
        }
        //view tạo hàng hóa
        [Route("themhanghoa")]
        public IActionResult themhanghoa()
        {
            ViewBag.nhomhanghoa = _context.Nhom_hang_hoas.ToList();
            return View("hanghoa/themhanghoa");
        }
        //hàm tạo hàng hóa
        [HttpPost]
        public IActionResult themhanghoa(Hanghoa hanghoa)
        {
            if (ModelState.IsValid)
            {
                if (_context.Hanghoas.Any(a => a.Mahang == hanghoa.Mahang) || _context.Hanghoas.Any(a => a.Idhanghoa == hanghoa.Idhanghoa))
                {
                    TempData["alertMessage1"] = "Mã hàng hóa hoặc ID hàng hóa bị trùng";
                    return RedirectToAction("themhanghoa");
                }
                else
                {
                    _context.Hanghoas.Add(hanghoa);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Thêm hàng hóa thành công";
                    return RedirectToAction("hanghoa");
                }
            }
            else
            {
                ViewBag.nhomhanghoa = _context.Nhom_hang_hoas.ToList();
                return View("hanghoa/themhanghoa");
            }

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
                    return RedirectToAction("hanghoa");
                }
                else
                {
                    _context.Update(hh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "update thành công";
                    return RedirectToAction("hanghoa");
                }
            }
        }
//===========================================================================================================
//=================================Khách hàng================================================================
        //view khách hàng
        public IActionResult khachhang(string id)
        {
           
            return View("khachhang/khachhang",_context.KhachHangs.Where(a => a.Visible == true).ToList());
        }
        //view chi tiết và edit khách hàng
        public IActionResult detailKH(string id)
        {
            ViewBag.khuvuc = _context.Khuvucs.ToList();
            ViewBag.list_qg = _context.Quocgia.ToList();
            ViewBag.idKH = (from a in _context.KhachHangs where a.Idkhach == id select a.Idkhach).FirstOrDefault();
            ViewBag.signer = from kh in _context.KhachHangs join sn in _context.Signers on kh.MaKhach equals sn.MaKhach where kh.Idkhach == id select sn;
            ViewBag.customerNorm = from a in _context.KhachHangs join b in _context.CustomerNorms on a.MaKhach equals b.Makhach where a.Idkhach == id select b;
            var ct_kh = _context.KhachHangs.Where(a => a.Visible == true && a.Idkhach == id).FirstOrDefault();
            return View("khachhang/detailKH",ct_kh);
        }
        //View thêm khách hàng
        public IActionResult themkhachhang()
        {
            ViewBag.khuvuc = _context.Khuvucs.ToList();
            ViewBag.list_qg = _context.Quocgia.ToList();
            return View("khachhang/themkhachhang");
        }
        //function thêm khách hàng
        [HttpPost]
        public IActionResult themkhachhang(KhachHang kh)
        {
            if (_context.KhachHangs.Any(a => a.Idkhach == kh.Idkhach) || _context.KhachHangs.Any(a => a.MaKhach == kh.MaKhach))
            {
                TempData["alertMessage1"] = "Mã khách hàng hoặc ID khách hàng bị trùng";
                return RedirectToAction("themkhachhang");
            }
            else
            {

                _context.KhachHangs.Add(kh);
                _context.SaveChanges();

                TempData["alertMessage"] = "thêm khách hàng thành công";
                return RedirectToAction("khachhang");
            }
        }
        //function xóa khách hàng
        public IActionResult deleteKH(string id)
        {
            var kh = _context.KhachHangs.Where(a => a.Idkhach == id).FirstOrDefault();
            kh.Visible = false;
            _context.KhachHangs.Update(kh);
            _context.SaveChanges();
            TempData["alertMessage"] = "Xóa khách hàng thành công";
            return RedirectToAction("khachhang");
        }
        //function update khánh hàng
        [HttpPost]
        public IActionResult updateKH(KhachHang kh)
        {
            kh.Visible = true;
            _context.Update(kh);
            _context.SaveChanges();
            TempData["alertMessage"] = "update thành công";
            return RedirectToAction("khachhang");
        }
        //thêm người đại diện
        public IActionResult themnguoidaidien(string id)
        {
            ViewBag.makhach = (from a in _context.KhachHangs where a.Idkhach == id select a.MaKhach).FirstOrDefault();
            ViewBag.id = (from a in _context.KhachHangs where a.Idkhach == id select a.Idkhach).FirstOrDefault();
            return View("khachhang/themnguoidaidien");
        }
        //function thêm người đại diện
        [HttpPost]
        public IActionResult themnguoidaidien(Signer signer, string id)
        {
                if (_context.Signers.Any(a => a.Id == signer.Id))
                {
                    TempData["alertMessage1"] = "Mã người đại diện bị trùng";
                    return RedirectToAction("khachhang");
                }
                else
                {
                    signer.Id = 0;
                    int stt = (from a in _context.KhachHangs
                               join b in _context.Signers on a.MaKhach equals b.MaKhach
                               where a.Idkhach == id
                               select a).Count();

                    signer.Stt = stt;
                    ViewBag.khuvuc = _context.Khuvucs.ToList();
                    ViewBag.list_qg = _context.Quocgia.ToList();
                    ViewBag.idKH = (from a in _context.KhachHangs where a.Idkhach == id select a.Idkhach).FirstOrDefault();
                    ViewBag.signer = from kh in _context.KhachHangs join sn in _context.Signers on kh.MaKhach equals sn.MaKhach where kh.Idkhach == id select sn;
                    ViewBag.customerNorm = from a in _context.KhachHangs join b in _context.CustomerNorms on a.MaKhach equals b.Makhach where a.Idkhach == id select b;
                    var ct_kh = _context.KhachHangs.Where(a => a.Visible == true && a.Idkhach == id).FirstOrDefault();
                    _context.Signers.Add(signer);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "thêm người đại diện thành công";
                    return View("khachhang/detailKH",ct_kh);
                }             
        }
        //update người kí
        public IActionResult updateSigner(int id)
        {
            
            ViewBag.makhach = (from a in _context.KhachHangs join b in _context.Signers on a.MaKhach equals b.MaKhach where b.Id == id select a.Idkhach).FirstOrDefault();
            return View("khachhang/updateSigner",_context.Signers.Where(a => a.Id == id).FirstOrDefault());
        }
        //function update người kí
        [HttpPost]
        public IActionResult updateSigner(Signer sn)
        {
            var item = (from a in _context.Signers where a.Id == sn.Id select a).FirstOrDefault();
            item.Nguoiky = sn.Nguoiky;
            item.Chucvu = sn.Chucvu;
            item.Uyquyen = sn.Uyquyen;
            item.Visible = true; 
            _context.Update(item).Property(a => a.Id).IsModified = false;
            /* _context.Signers.Update(item);*/
            _context.SaveChanges();
            TempData["alertMessage"] = "cập nhật người đại diện thành công";
            return RedirectToAction("khachhang");
        }
        //thêm định mức
        public IActionResult themdinhmuc(string id)
        {
            ViewBag.makhach = (from a in _context.KhachHangs where a.Idkhach == id select a.MaKhach).FirstOrDefault();
            ViewBag.id = (from a in _context.KhachHangs where a.Idkhach == id select a.Idkhach).FirstOrDefault();
            ViewBag.branch = _context.Branches.ToList();
            ViewBag.nhomhang = _context.Nhom_hang_hoas.ToList();
            return View("khachhang/themdinhmuc");
        }
        //function thêm định mức
        [HttpPost]
        public IActionResult themdinhmuc(CustomerNorm customerNorm,string id)
        {
            if (!(_context.CustomerNorms.Any(a => a.Macn == customerNorm.Macn) && _context.CustomerNorms.Any(a => a.Nhomhang == customerNorm.Nhomhang)))

            {
                var rand = new Random();
                customerNorm.Id = rand.Next(0000, 9999);
                customerNorm.Makhach = (from a in _context.KhachHangs where a.Idkhach == id select a.MaKhach).FirstOrDefault();
                customerNorm.UserCreate = HttpContext.Session.GetString("userId");
                customerNorm.DateCreate = DateTime.Now;
                customerNorm.GdMua = false;
                customerNorm.GdBan = false;
                /*                _context.Entry(customerNorm).State = EntityState.Added;*/
                ViewBag.khuvuc = _context.Khuvucs.ToList();
                ViewBag.list_qg = _context.Quocgia.ToList();
                ViewBag.idKH = (from a in _context.KhachHangs where a.Idkhach == id select a.Idkhach).FirstOrDefault();
                ViewBag.signer = from kh in _context.KhachHangs join sn in _context.Signers on kh.MaKhach equals sn.MaKhach where kh.Idkhach == id select sn;
                ViewBag.customerNorm = from a in _context.KhachHangs join b in _context.CustomerNorms on a.MaKhach equals b.Makhach where a.Idkhach == id select b;
                var ct_kh = _context.KhachHangs.Where(a => a.Visible == true && a.Idkhach == id).FirstOrDefault();
                _context.CustomerNorms.Add(customerNorm);
                _context.SaveChanges();
                TempData["alertMessage"] = "thêm người đại diện thành công";
                return View("khachhang/detailKH",ct_kh);
            }
            else
            {
                TempData["alertMessage1"] = "Mã chi nhánh và mã nhóm hàng bị trùng, vui lòng nhập lại";
                return RedirectToAction("themdinhmuc");
            }

        }
        //update customer norm
        public IActionResult updateCN(long id)
        {
            ViewBag.branch = _context.Branches.ToList();
            ViewBag.nhomhang = _context.Nhom_hang_hoas.ToList();
            return View("khachhang/updateCN",_context.CustomerNorms.Where(a => a.Id == id).FirstOrDefault());
        }
        //function update customer norm
        [HttpPost]
        public IActionResult updateCustomerNorm(CustomerNorm customerNorm)
        {
            var rd = new Random();
            customerNorm.Id = rd.Next(0000, 9999);
            _context.CustomerNorms.Update(customerNorm);
            _context.SaveChanges();
            TempData["alertMessage"] = "cập nhật người đại diện thành công";
            return RedirectToAction("khachhang");
            

        }
        public IActionResult aaa()
        {
            var cn = _context.CustomerNorms.ToList();
            return Json(cn);
        }
        //function xóa customer norm
        public IActionResult deleteCN(long id)
        {
            var cn = _context.CustomerNorms.Where(a => a.Id == id).FirstOrDefault();
            _context.CustomerNorms.Remove(cn);
            _context.SaveChanges();
            TempData["alertMessage"] = "xóa người đại diện thành công";
            return RedirectToAction("khachhang");
        }
    }
}

