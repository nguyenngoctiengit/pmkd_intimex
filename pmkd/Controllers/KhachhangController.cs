using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using pmkd.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class KhachhangController : Controller
    {
        private readonly tradingsystem_blContext _context = new tradingsystem_blContext(Parameter.connectionString);
        public KhachhangController()
        {
        }
        public IActionResult khachhang(string id)
        {
            ViewBag.khuvuc = _context.Khuvucs.ToList();
            ViewBag.tenqg = _context.Quocgia.ToList();
            var model = _context.KhachHangs.Where(a => a.Visible == true).ToList();
            return View("khachhang", model);
        }
        //View thêm khách hàng
        public IActionResult themkhachhang()
        {
            ViewBag.khuvuc = _context.Khuvucs.ToList();
            ViewBag.list_qg = _context.Quocgia.ToList();
            return View("themkhachhang");
        }
        //function thêm khách hàng

        [HttpPost]
        public IActionResult themkhachhang(KhachHang kh)
        {
            var ran = new Random();
            kh.Idkhach = "KH" + ran.Next(0000, 9999);
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
        //lấy dữ liệu khách hàng
        [HttpGet]
        public async Task<IActionResult> GetKH(DataSourceLoadOptions loadOptions)
        {
            var khachhangs = _context.KhachHangs.Select(i => new {
                i.Idkhach,
                i.MaKhach,
                i.TenKhach,
                i.TenFull,
                i.Email,
                i.DiaChi,
                i.DienThoai,
                i.Fax,
                i.MaSoThue,
                i.TaiKhoan,
                i.NganHang,
                i.GiayPhep,
                i.NgayCap,
                i.MaCn,
                i.MatHang,
                i.CheckItem,
                i.CheckTh,
                i.GiaoDichMua,
                i.ThanhToanMua,
                i.GiaoDichBan,
                i.ThanhToanBan,
                i.GhiChu,
                i.GiaoDich,
                i.DateActive,
                i.MaKhuvuc,
                i.TenQg,
                i.ToaKinhTe,
                i.CreatedDate,
                i.CreatedBy,
                i.ModifiedDate,
                i.ModifiedBy,
                i.Vanchuyen,
                i.Bocxep,
                i.LoaiKhach,
                i.NguoiKy1,
                i.ChucVu1,
                i.UyQuyen1,
                i.NguoiKy2,
                i.ChucVu2,
                i.UyQuyen2,
                i.Visible,
                i.Sanluong,
                i.Dientich,
                i.MaHd
            });
            return Json(await DataSourceLoader.LoadAsync(khachhangs, loadOptions));
        }
        //function thêm khách hàng
        [HttpPost]
        public async Task<IActionResult> PostKH(string values)
        {
            var model = new KhachHang();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);
            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));
            var result = _context.KhachHangs.Add(model);
            await _context.SaveChangesAsync();
            return Json(new { result.Entity.Idkhach, result.Entity.MaKhach });
        }
        //function sửa khách hàng
        [HttpPut]
        public async Task<IActionResult> PutKH(string key, string values)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyIdkhach = Convert.ToString(keys["Idkhach"]);
            var keyMaKhach = Convert.ToString(keys["MaKhach"]);
            var model = await _context.KhachHangs.FirstOrDefaultAsync(item =>
                            item.Idkhach == keyIdkhach &&
                            item.MaKhach == keyMaKhach);
            if (model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }
        //function xóa khách hàng
        [HttpDelete]
        public async Task DeleteKH(string key)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyIdkhach = Convert.ToString(keys["Idkhach"]);
            var keyMaKhach = Convert.ToString(keys["MaKhach"]);
            var model = await _context.KhachHangs.FirstOrDefaultAsync(item =>
                            item.Idkhach == keyIdkhach &&
                            item.MaKhach == keyMaKhach);

            _context.KhachHangs.Remove(model);
            await _context.SaveChangesAsync();
        }

        //model khách hàng
        private void PopulateModel(KhachHang model, IDictionary values)
        {
            string IDKHACH = nameof(KhachHang.Idkhach);
            string MA_KHACH = nameof(KhachHang.MaKhach);
            string TEN_KHACH = nameof(KhachHang.TenKhach);
            string TEN_FULL = nameof(KhachHang.TenFull);
            string EMAIL = nameof(KhachHang.Email);
            string DIA_CHI = nameof(KhachHang.DiaChi);
            string DIEN_THOAI = nameof(KhachHang.DienThoai);
            string FAX = nameof(KhachHang.Fax);
            string MA_SO_THUE = nameof(KhachHang.MaSoThue);
            string TAI_KHOAN = nameof(KhachHang.TaiKhoan);
            string NGAN_HANG = nameof(KhachHang.NganHang);
            string GIAY_PHEP = nameof(KhachHang.GiayPhep);
            string NGAY_CAP = nameof(KhachHang.NgayCap);
            string MA_CN = nameof(KhachHang.MaCn);
            string MAT_HANG = nameof(KhachHang.MatHang);
            string CHECK_ITEM = nameof(KhachHang.CheckItem);
            string CHECK_TH = nameof(KhachHang.CheckTh);
            string GIAO_DICH_MUA = nameof(KhachHang.GiaoDichMua);
            string THANH_TOAN_MUA = nameof(KhachHang.ThanhToanMua);
            string GIAO_DICH_BAN = nameof(KhachHang.GiaoDichBan);
            string THANH_TOAN_BAN = nameof(KhachHang.ThanhToanBan);
            string GHI_CHU = nameof(KhachHang.GhiChu);
            string GIAO_DICH = nameof(KhachHang.GiaoDich);
            string DATE_ACTIVE = nameof(KhachHang.DateActive);
            string MA_KHUVUC = nameof(KhachHang.MaKhuvuc);
            string TEN_QG = nameof(KhachHang.TenQg);
            string TOA_KINH_TE = nameof(KhachHang.ToaKinhTe);
            string CREATED_DATE = nameof(KhachHang.CreatedDate);
            string CREATED_BY = nameof(KhachHang.CreatedBy);
            string MODIFIED_DATE = nameof(KhachHang.ModifiedDate);
            string MODIFIED_BY = nameof(KhachHang.ModifiedBy);
            string VANCHUYEN = nameof(KhachHang.Vanchuyen);
            string BOCXEP = nameof(KhachHang.Bocxep);
            string LOAI_KHACH = nameof(KhachHang.LoaiKhach);
            string NGUOI_KY1 = nameof(KhachHang.NguoiKy1);
            string CHUC_VU1 = nameof(KhachHang.ChucVu1);
            string UY_QUYEN1 = nameof(KhachHang.UyQuyen1);
            string NGUOI_KY2 = nameof(KhachHang.NguoiKy2);
            string CHUC_VU2 = nameof(KhachHang.ChucVu2);
            string UY_QUYEN2 = nameof(KhachHang.UyQuyen2);
            string VISIBLE = nameof(KhachHang.Visible);
            string SANLUONG = nameof(KhachHang.Sanluong);
            string DIENTICH = nameof(KhachHang.Dientich);
            string MA_HD = nameof(KhachHang.MaHd);

            if (values.Contains(IDKHACH))
            {
                model.Idkhach = Convert.ToString(values[IDKHACH]);
            }

            if (values.Contains(MA_KHACH))
            {
                model.MaKhach = Convert.ToString(values[MA_KHACH]);
            }

            if (values.Contains(TEN_KHACH))
            {
                model.TenKhach = Convert.ToString(values[TEN_KHACH]);
            }

            if (values.Contains(TEN_FULL))
            {
                model.TenFull = Convert.ToString(values[TEN_FULL]);
            }

            if (values.Contains(EMAIL))
            {
                model.Email = Convert.ToString(values[EMAIL]);
            }

            if (values.Contains(DIA_CHI))
            {
                model.DiaChi = Convert.ToString(values[DIA_CHI]);
            }

            if (values.Contains(DIEN_THOAI))
            {
                model.DienThoai = Convert.ToString(values[DIEN_THOAI]);
            }

            if (values.Contains(FAX))
            {
                model.Fax = Convert.ToString(values[FAX]);
            }

            if (values.Contains(MA_SO_THUE))
            {
                model.MaSoThue = Convert.ToString(values[MA_SO_THUE]);
            }

            if (values.Contains(TAI_KHOAN))
            {
                model.TaiKhoan = Convert.ToString(values[TAI_KHOAN]);
            }

            if (values.Contains(NGAN_HANG))
            {
                model.NganHang = Convert.ToString(values[NGAN_HANG]);
            }

            if (values.Contains(GIAY_PHEP))
            {
                model.GiayPhep = Convert.ToString(values[GIAY_PHEP]);
            }

            if (values.Contains(NGAY_CAP))
            {
                model.NgayCap = values[NGAY_CAP] != null ? Convert.ToDateTime(values[NGAY_CAP]) : (DateTime?)null;
            }

            if (values.Contains(MA_CN))
            {
                model.MaCn = Convert.ToString(values[MA_CN]);
            }

            if (values.Contains(MAT_HANG))
            {
                model.MatHang = Convert.ToString(values[MAT_HANG]);
            }

            if (values.Contains(CHECK_ITEM))
            {
                model.CheckItem = values[CHECK_ITEM] != null ? Convert.ToBoolean(values[CHECK_ITEM]) : (bool?)null;
            }

            if (values.Contains(CHECK_TH))
            {
                model.CheckTh = Convert.ToBoolean(values[CHECK_TH]);
            }

            if (values.Contains(GIAO_DICH_MUA))
            {
                model.GiaoDichMua = values[GIAO_DICH_MUA] != null ? Convert.ToBoolean(values[GIAO_DICH_MUA]) : (bool?)null;
            }

            if (values.Contains(THANH_TOAN_MUA))
            {
                model.ThanhToanMua = values[THANH_TOAN_MUA] != null ? Convert.ToBoolean(values[THANH_TOAN_MUA]) : (bool?)null;
            }

            if (values.Contains(GIAO_DICH_BAN))
            {
                model.GiaoDichBan = values[GIAO_DICH_BAN] != null ? Convert.ToBoolean(values[GIAO_DICH_BAN]) : (bool?)null;
            }

            if (values.Contains(THANH_TOAN_BAN))
            {
                model.ThanhToanBan = values[THANH_TOAN_BAN] != null ? Convert.ToBoolean(values[THANH_TOAN_BAN]) : (bool?)null;
            }

            if (values.Contains(GHI_CHU))
            {
                model.GhiChu = Convert.ToString(values[GHI_CHU]);
            }

            if (values.Contains(GIAO_DICH))
            {
                model.GiaoDich = values[GIAO_DICH] != null ? Convert.ToInt32(values[GIAO_DICH]) : (int?)null;
            }

            if (values.Contains(DATE_ACTIVE))
            {
                model.DateActive = values[DATE_ACTIVE] != null ? Convert.ToDateTime(values[DATE_ACTIVE]) : (DateTime?)null;
            }

            if (values.Contains(MA_KHUVUC))
            {
                model.MaKhuvuc = Convert.ToString(values[MA_KHUVUC]);
            }

            if (values.Contains(TEN_QG))
            {
                model.TenQg = Convert.ToString(values[TEN_QG]);
            }

            if (values.Contains(TOA_KINH_TE))
            {
                model.ToaKinhTe = Convert.ToString(values[TOA_KINH_TE]);
            }

            if (values.Contains(CREATED_DATE))
            {
                model.CreatedDate = values[CREATED_DATE] != null ? Convert.ToDateTime(values[CREATED_DATE]) : (DateTime?)null;
            }

            if (values.Contains(CREATED_BY))
            {
                model.CreatedBy = Convert.ToString(values[CREATED_BY]);
            }

            if (values.Contains(MODIFIED_DATE))
            {
                model.ModifiedDate = values[MODIFIED_DATE] != null ? Convert.ToDateTime(values[MODIFIED_DATE]) : (DateTime?)null;
            }

            if (values.Contains(MODIFIED_BY))
            {
                model.ModifiedBy = Convert.ToString(values[MODIFIED_BY]);
            }

            if (values.Contains(VANCHUYEN))
            {
                model.Vanchuyen = Convert.ToString(values[VANCHUYEN]);
            }

            if (values.Contains(BOCXEP))
            {
                model.Bocxep = Convert.ToString(values[BOCXEP]);
            }

            if (values.Contains(LOAI_KHACH))
            {
                model.LoaiKhach = Convert.ToString(values[LOAI_KHACH]);
            }

            if (values.Contains(NGUOI_KY1))
            {
                model.NguoiKy1 = Convert.ToString(values[NGUOI_KY1]);
            }

            if (values.Contains(CHUC_VU1))
            {
                model.ChucVu1 = Convert.ToString(values[CHUC_VU1]);
            }

            if (values.Contains(UY_QUYEN1))
            {
                model.UyQuyen1 = Convert.ToString(values[UY_QUYEN1]);
            }

            if (values.Contains(NGUOI_KY2))
            {
                model.NguoiKy2 = Convert.ToString(values[NGUOI_KY2]);
            }

            if (values.Contains(CHUC_VU2))
            {
                model.ChucVu2 = Convert.ToString(values[CHUC_VU2]);
            }

            if (values.Contains(UY_QUYEN2))
            {
                model.UyQuyen2 = Convert.ToString(values[UY_QUYEN2]);
            }

            if (values.Contains(VISIBLE))
            {
                model.Visible = values[VISIBLE] != null ? Convert.ToBoolean(values[VISIBLE]) : (bool?)null;
            }

            if (values.Contains(SANLUONG))
            {
                model.Sanluong = Convert.ToDecimal(values[SANLUONG], CultureInfo.InvariantCulture);
            }

            if (values.Contains(DIENTICH))
            {
                model.Dientich = Convert.ToDecimal(values[DIENTICH], CultureInfo.InvariantCulture);
            }

            if (values.Contains(MA_HD))
            {
                model.MaHd = Convert.ToString(values[MA_HD]);
            }
        }
        //lấy dữ liệu định mức khách hàng
        [HttpGet]
        public object GetCN(DataSourceLoadOptions loadOptions, string IDkhachhang)
        {
            var cthdmbs = from a in _context.KhachHangs
                          join b in _context.CustomerNorms on a.MaKhach equals b.Makhach
                          where a.Idkhach == IDkhachhang
                          select new
                          {
                              b.Id,
                              b.Makhach,
                              b.Nhomhang,
                              b.ValueNorm,
                              b.Macn,
                              b.NguoiGd,
                              b.ChucvuNguoigd,
                              b.Ghichu,
                              b.UserCreate,
                              b.DateCreate
                          };
            return DataSourceLoader.Load(cthdmbs, loadOptions);
        }
        //lấy dữ liệu đơn vị (branch)

        //functin thêm định mức khách hàng
        [HttpPost]
        public async Task<IActionResult> PostCN(string values, string IDkhachhang)
        {
            var model = new CustomerNorm();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModelCN(model, valuesDict);
            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));
            model.UserCreate = HttpContext.Session.GetString("userId");
            model.DateCreate = DateTime.Now;
            model.GdMua = false;
            model.GdBan = false;
            model.Macn = HttpContext.Session.GetString("UnitName");
            var result = _context.CustomerNorms.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.Id, result.Entity.Macn, result.Entity.Makhach, result.Entity.Nhomhang });
        }
        //cập nhật định mức khách hàng
        [HttpPut]
        public async Task<IActionResult> PutCN(long key, string values, string IDkhachhang)
        {
            var model = await _context.CustomerNorms.FirstOrDefaultAsync(item =>
                            item.Id == key);

            if (model == null)
                return StatusCode(409, "Object not found");
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModelCN(model, valuesDict);
            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));
            await _context.SaveChangesAsync();
            return Ok();
        }
        //function xóa định mức khách hàng
        [HttpDelete]
        public async Task DeleteCN(long key)
        {
            var model = await _context.CustomerNorms.FirstOrDefaultAsync(item =>
                            item.Id == key);
            _context.CustomerNorms.Remove(model);
            await _context.SaveChangesAsync();
        }
        // model định mức khách hàng
        private void PopulateModelCN(CustomerNorm model, IDictionary values)
        {
            string ID = nameof(CustomerNorm.Id);
            string MAKHACH = nameof(CustomerNorm.Makhach);
            string NHOMHANG = nameof(CustomerNorm.Nhomhang);
            string MACN = nameof(CustomerNorm.Macn);
            string VALUE_NORM = nameof(CustomerNorm.ValueNorm);
            string VALUE_DMGH = nameof(CustomerNorm.ValueDmgh);
            string GHICHU = nameof(CustomerNorm.Ghichu);
            string NGUOI_GD = nameof(CustomerNorm.NguoiGd);
            string CHUCVU_NGUOIGD = nameof(CustomerNorm.ChucvuNguoigd);
            string USER_CREATE = nameof(CustomerNorm.UserCreate);
            string DATE_CREATE = nameof(CustomerNorm.DateCreate);
            string USER_MODIFY = nameof(CustomerNorm.UserModify);
            string DATE_MODIFY = nameof(CustomerNorm.DateModify);
            string GD_MUA = nameof(CustomerNorm.GdMua);
            string GD_BAN = nameof(CustomerNorm.GdBan);

            if (values.Contains(ID))
            {
                model.Id = Convert.ToInt64(values[ID]);
            }

            if (values.Contains(MAKHACH))
            {
                model.Makhach = Convert.ToString(values[MAKHACH]);
            }

            if (values.Contains(NHOMHANG))
            {
                model.Nhomhang = Convert.ToString(values[NHOMHANG]);
            }

            if (values.Contains(MACN))
            {
                model.Macn = Convert.ToString(values[MACN]);
            }

            if (values.Contains(VALUE_NORM))
            {
                model.ValueNorm = Convert.ToDecimal(values[VALUE_NORM], CultureInfo.InvariantCulture);
            }

            if (values.Contains(VALUE_DMGH))
            {
                model.ValueDmgh = Convert.ToDecimal(values[VALUE_DMGH], CultureInfo.InvariantCulture);
            }

            if (values.Contains(GHICHU))
            {
                model.Ghichu = Convert.ToString(values[GHICHU]);
            }

            if (values.Contains(NGUOI_GD))
            {
                model.NguoiGd = Convert.ToString(values[NGUOI_GD]);
            }

            if (values.Contains(CHUCVU_NGUOIGD))
            {
                model.ChucvuNguoigd = Convert.ToString(values[CHUCVU_NGUOIGD]);
            }

            if (values.Contains(USER_CREATE))
            {
                model.UserCreate = Convert.ToString(values[USER_CREATE]);
            }

            if (values.Contains(DATE_CREATE))
            {
                model.DateCreate = values[DATE_CREATE] != null ? Convert.ToDateTime(values[DATE_CREATE]) : (DateTime?)null;
            }

            if (values.Contains(USER_MODIFY))
            {
                model.UserModify = Convert.ToString(values[USER_MODIFY]);
            }

            if (values.Contains(DATE_MODIFY))
            {
                model.DateModify = values[DATE_MODIFY] != null ? Convert.ToDateTime(values[DATE_MODIFY]) : (DateTime?)null;
            }

            if (values.Contains(GD_MUA))
            {
                model.GdMua = values[GD_MUA] != null ? Convert.ToBoolean(values[GD_MUA]) : (bool?)null;
            }

            if (values.Contains(GD_BAN))
            {
                model.GdBan = values[GD_BAN] != null ? Convert.ToBoolean(values[GD_BAN]) : (bool?)null;
            }
        }
        //lấy dữ lại người đại diện
        [HttpGet]
        public object GetSN(DataSourceLoadOptions loadOptions, string IDkhachhang)
        {
            var item_return = from a in _context.KhachHangs
                              join b in _context.Signers on a.MaKhach equals b.MaKhach
                              where a.Idkhach == IDkhachhang
                              select new
                              {
                                  b.MaKhach,
                                  b.Id,
                                  b.Stt,
                                  b.Nguoiky,
                                  b.Chucvu,
                                  b.Uyquyen
                              };
            return DataSourceLoader.Load(item_return, loadOptions);
        }
        //lấy dữ liệu mã khách hàng


        //function thêm người đại diện khách hàng
        [HttpPost]
        public async Task<IActionResult> PostSN(string values, string IDkhachhang)
        {
            var model = new Signer();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModelSN(model, valuesDict);
            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Signers.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.Id, result.Entity.MaKhach, result.Entity.Stt });
        }
        //function sửa người đại diện khách hàng
        [HttpPut]
        public async Task<IActionResult> PutSN(long key, string values)
        {
            var model = await _context.Signers.FirstOrDefaultAsync(item =>
                            item.Id == key);
            if (model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModelSN(model, valuesDict);

            if (!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }
        //function xóa người đại diện khách hàng
        [HttpDelete]
        public async Task DeleteSN(long key)
        {
            var model = await _context.Signers.FirstOrDefaultAsync(a => a.Id == key);

            _context.Signers.Remove(model);
            await _context.SaveChangesAsync();
        }

        //model người đại diện khách hàng
        private void PopulateModelSN(Signer model, IDictionary values)
        {
            string ID = nameof(Signer.Id);
            string STT = nameof(Signer.Stt);
            string MA_KHACH = nameof(Signer.MaKhach);
            string NGUOIKY = nameof(Signer.Nguoiky);
            string CHUCVU = nameof(Signer.Chucvu);
            string UYQUYEN = nameof(Signer.Uyquyen);
            string VISIBLE = nameof(Signer.Visible);

            if (values.Contains(ID))
            {
                model.Id = Convert.ToInt64(values[ID]);
            }

            if (values.Contains(STT))
            {
                model.Stt = Convert.ToInt32(values[STT]);
            }

            if (values.Contains(MA_KHACH))
            {
                model.MaKhach = Convert.ToString(values[MA_KHACH]);
            }

            if (values.Contains(NGUOIKY))
            {
                model.Nguoiky = Convert.ToString(values[NGUOIKY]);
            }

            if (values.Contains(CHUCVU))
            {
                model.Chucvu = Convert.ToString(values[CHUCVU]);
            }

            if (values.Contains(UYQUYEN))
            {
                model.Uyquyen = Convert.ToString(values[UYQUYEN]);
            }

            if (values.Contains(VISIBLE))
            {
                model.Visible = values[VISIBLE] != null ? Convert.ToBoolean(values[VISIBLE]) : (bool?)null;
            }
        }
        //function get lỗi
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

    }
}
