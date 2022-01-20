using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.SignalR;
using Application.AutoId;

namespace Intimex_project.Controllers
{
    public class HanghoaController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public HanghoaController()
        {
        }
        public IActionResult hanghoa()
        {
            return View();

        }
        //hàm thêm nhóm hàng hóa
        [HttpPost]
        public IActionResult themnhomhang(string MaNhom,string TenNhom)
        {
            if (_context.Nhom_hang_hoas.Any(x => x.Manhom == MaNhom))
            {
                return Json("Mã nhóm hàng bị trùng, không thể thêm, mời nhập lại");
            }
            else
            {
                var item = new Nhom_hang_hoa();
                item.Manhom = MaNhom;
                item.TenNhom = TenNhom;
                _context.Nhom_hang_hoas.Add(item);
                _context.SaveChanges();
                return Json("Thêm nhóm hàng thành công");
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
        public IActionResult AddOrEditHangHoa(string Idhanghoa)
        {
            if (Idhanghoa != "")
            {
                ViewBag.id = _context.Hanghoas.Where(a => a.Idhanghoa == Idhanghoa).Select(a => a.Idhanghoa).FirstOrDefault();
                var HangHoa = _context.Hanghoas.Where(a => a.Idhanghoa == Idhanghoa).FirstOrDefault();
                return PartialView("_PartiView_AddOrEdit_Hanghoa",HangHoa);
            }
            else
            {
                return PartialView("_PartiView_AddOrEdit_Hanghoa");
            }
        }
        [HttpPost]
        public IActionResult AddOrEdit_HangHoa(string id, Hanghoa hanghoa)
        {
            if (id == "" || id == null)
            {
                if (_context.Hanghoas.Any(a => a.Mahang == hanghoa.Mahang))
                {
                    TempData["alertMessage"] = "Mã hàng hóa bị trùng";
                    return RedirectToAction("hanghoa");
                }
                else
                {
                    Hanghoa hh = new Hanghoa();
                    hh.Idhanghoa = AutoId.AutoIdHangHoa("Hanghoa");
                    hh.Mahang = hanghoa.Mahang;
                    hh.Tenhang = hanghoa.Tenhang;
                    hh.MaNhom = hanghoa.MaNhom;
                    hh.Dvt = hanghoa.Dvt;
                    hh.Vat = hanghoa.Vat;
                    hh.Fullname = hanghoa.Fullname;
                    hh.Quicach = hanghoa.Quicach;
                    hh.Baobi = hanghoa.Baobi;
                    hh.Kiemdinh = hanghoa.Kiemdinh;
                    hh.Tenhangvat = hanghoa.Tenhangvat;
                    hh.DoAm = 0;
                    hh.HatDen = 0;
                    hh.TapChat = 0;
                    hh.HatVo = 0;
                    _context.Hanghoas.Add(hh);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Thêm hàng hóa thành công";
                    return RedirectToAction("hanghoa");
                }
            }
            else
            {
                var hh = _context.Hanghoas.Where(a => a.Idhanghoa == id).FirstOrDefault();
                hh.Mahang = hanghoa.Mahang;
                hh.Tenhang = hanghoa.Tenhang;
                hh.MaNhom = hanghoa.MaNhom;
                hh.Dvt = hanghoa.Dvt;
                hh.Vat = hanghoa.Vat;
                hh.Fullname = hanghoa.Fullname;
                hh.Quicach = hanghoa.Quicach;
                hh.Baobi = hanghoa.Baobi;
                hh.Kiemdinh = hanghoa.Kiemdinh;
                hh.Tenhangvat = hanghoa.Tenhangvat;
                hh.DoAm = 0;
                hh.HatDen = 0;
                hh.TapChat = 0;
                hh.HatVo = 0;
                _context.Hanghoas.Update(hh);
                _context.SaveChanges();
                TempData["alertMessage"] = "Chỉnh sửa hàng hóa thành công";
                return RedirectToAction("hanghoa");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string key)
        {
            var keys = JsonConvert.DeserializeObject<IDictionary>(key);
            var keyIdhanghoa = Convert.ToString(keys["Idhanghoa"]);
            var keyMahang = Convert.ToString(keys["Mahang"]);
            var model = await _context.Hanghoas.FirstOrDefaultAsync(item =>
                            item.Idhanghoa == keyIdhanghoa &&
                            item.Mahang == keyMahang);
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
                    return BadRequest("Hàng hóa đang giao dịch, không được xóa");
                }
            }
            _context.Hanghoas.Remove(model);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
