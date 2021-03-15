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
using RouteAttribute = ServiceStack.RouteAttribute;
using System.Web;
using DevExtreme.AspNet.Data;
using System.Collections;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DevExtreme.AspNet.Mvc;

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
                    return RedirectToAction("hanghoa");
                }
                else
                {
                    _context.Nhom_hang_hoas.Add(nhh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Thêm nhóm hàng thành công";
                    return RedirectToAction("hanghoa");
                }
            }
            else
                return View("hanghoa/themnhomhang");

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
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            var hanghoas = _context.Hanghoas.Select(i => new {
                i.Idhanghoa,
                i.Mahang,
                i.Tenhang,
                i.Tenhangvat,
                i.MaNhom,
                i.Dvt,
                i.Vat,
                i.Sudung,
                i.Fullname,
                i.Quicach,
                i.Baobi,
                i.Kiemdinh,
                i.Visible,
                i.OrderNhom,
                i.DoAm,
                i.HatDen,
                i.TapChat,
                i.HatVo
            });
            return Json(await DataSourceLoader.LoadAsync(hanghoas, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values)
        {
            var model = new Hanghoa();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            if (_context.Hanghoas.Any(a => a.Idhanghoa == model.Idhanghoa) || _context.Hanghoas.Any(a => a.Mahang == model.Mahang))
            {
                return BadRequest("Mã hàng hóa hoặc ID hàng hóa bị trùng");
            }
            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Hanghoas.Add(model);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyIdhanghoa = Convert.ToString(keys["Idhanghoa"]);
            var keyMahang = Convert.ToString(keys["Mahang"]);
            var model = await _context.Hanghoas.FirstOrDefaultAsync(item =>
                            item.Idhanghoa == keyIdhanghoa &&
                            item.Mahang == keyMahang);
            if (model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            var flag = false;
            var list_contac = _context.CtHdmbs.ToList();
            {
                foreach (var a in list_contac)
                {
                    if (a.Mahang == model.Mahang)
                    {
                        flag = true;
                    }    
                }    
                if (flag == true)
                {
                    return BadRequest("Hàng hóa đang giao dịch, không được sửa");
                }
            }
            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task  Delete(string key)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyIdhanghoa = Convert.ToString(keys["Idhanghoa"]);
            var keyMahang = Convert.ToString(keys["Mahang"]);
            var model = await _context.Hanghoas.FirstOrDefaultAsync(item =>
                            item.Idhanghoa == keyIdhanghoa &&
                            item.Mahang == keyMahang);

            _context.Hanghoas.Remove(model);
            await _context.SaveChangesAsync();
        }
        [HttpGet]
        public async Task <IActionResult>Getnhomhang(DataSourceLoadOptions loadOptions)
        {
            var manhomhang = _context.Nhom_hang_hoas.Select(i => new {
                i.Manhom,
                i.TenNhom
            });
            
            return Json(await DataSourceLoader.LoadAsync(manhomhang, loadOptions));
        }

        private void PopulateModel(Hanghoa model, IDictionary values)
        {
            string IDHANGHOA = nameof(Hanghoa.Idhanghoa);
            string MAHANG = nameof(Hanghoa.Mahang);
            string TENHANG = nameof(Hanghoa.Tenhang);
            string TENHANGVAT = nameof(Hanghoa.Tenhangvat);
            string MA_NHOM = nameof(Hanghoa.MaNhom);
            string DVT = nameof(Hanghoa.Dvt);
            string VAT = nameof(Hanghoa.Vat);
            string SUDUNG = nameof(Hanghoa.Sudung);
            string FULLNAME = nameof(Hanghoa.Fullname);
            string QUICACH = nameof(Hanghoa.Quicach);
            string BAOBI = nameof(Hanghoa.Baobi);
            string KIEMDINH = nameof(Hanghoa.Kiemdinh);
            string VISIBLE = nameof(Hanghoa.Visible);
            string ORDER_NHOM = nameof(Hanghoa.OrderNhom);
            string DO_AM = nameof(Hanghoa.DoAm);
            string HAT_DEN = nameof(Hanghoa.HatDen);
            string TAP_CHAT = nameof(Hanghoa.TapChat);
            string HAT_VO = nameof(Hanghoa.HatVo);

            if (values.Contains(IDHANGHOA))
            {
                model.Idhanghoa = Convert.ToString(values[IDHANGHOA]);
            }

            if (values.Contains(MAHANG))
            {
                model.Mahang = Convert.ToString(values[MAHANG]);
            }

            if (values.Contains(TENHANG))
            {
                model.Tenhang = Convert.ToString(values[TENHANG]);
            }

            if (values.Contains(TENHANGVAT))
            {
                model.Tenhangvat = Convert.ToString(values[TENHANGVAT]);
            }

            if (values.Contains(MA_NHOM))
            {
                model.MaNhom = Convert.ToString(values[MA_NHOM]);
            }

            if (values.Contains(DVT))
            {
                model.Dvt = Convert.ToString(values[DVT]);
            }

            if (values.Contains(VAT))
            {
                model.Vat = values[VAT] != null ? Convert.ToInt32(values[VAT]) : (int?)null;
            }

            if (values.Contains(SUDUNG))
            {
                model.Sudung = values[SUDUNG] != null ? Convert.ToInt16(values[SUDUNG]) : (short?)null;
            }

            if (values.Contains(FULLNAME))
            {
                model.Fullname = Convert.ToString(values[FULLNAME]);
            }

            if (values.Contains(QUICACH))
            {
                model.Quicach = Convert.ToString(values[QUICACH]);
            }

            if (values.Contains(BAOBI))
            {
                model.Baobi = Convert.ToString(values[BAOBI]);
            }

            if (values.Contains(KIEMDINH))
            {
                model.Kiemdinh = Convert.ToString(values[KIEMDINH]);
            }

            if (values.Contains(VISIBLE))
            {
                model.Visible = values[VISIBLE] != null ? Convert.ToBoolean(values[VISIBLE]) : (bool?)null;
            }

            if (values.Contains(ORDER_NHOM))
            {
                model.OrderNhom = values[ORDER_NHOM] != null ? Convert.ToInt16(values[ORDER_NHOM]) : (short?)null;
            }

            if (values.Contains(DO_AM))
            {
                model.DoAm = values[DO_AM] != null ? Convert.ToDecimal(values[DO_AM], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if (values.Contains(HAT_DEN))
            {
                model.HatDen = values[HAT_DEN] != null ? Convert.ToDecimal(values[HAT_DEN], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if (values.Contains(TAP_CHAT))
            {
                model.TapChat = values[TAP_CHAT] != null ? Convert.ToDecimal(values[TAP_CHAT], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if (values.Contains(HAT_VO))
            {
                model.HatVo = values[HAT_VO] != null ? Convert.ToDecimal(values[HAT_VO], CultureInfo.InvariantCulture) : (decimal?)null;
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState)
        {
            var messages = new List<string>();

            foreach (var entry in modelState)
            {
                foreach (var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }
            
            return String.Join(" ", messages);
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
        public IActionResult view()
        {
            return View("view");
        }
    }
}

