using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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

namespace pmkd.Controllers.Danhmuc
{
    public class HanghoaController : Controller
    {
        public tradingsystem_blContext _context = new tradingsystem_blContext(ConnectionParameter.connectionString);
        public HanghoaController()
        {
        }
        public IActionResult hanghoa()
        {
            ViewBag.ListUser = (from a in _context.AspNetUsers select new AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online }).OrderByDescending(a => a.Online).ToList();
            return View();

        }
        //view thêm nhóm hàng hóa
        public IActionResult themnhomhang()
        {
            ViewBag.ListUser = (from a in _context.AspNetUsers select new AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online }).OrderByDescending(a => a.Online).ToList();
            return View("themnhomhang");
        }
        //hàm thêm nhóm hàng hóa
        [HttpPost]
        public IActionResult themnhomhang1(Nhom_hang_hoa nhh)
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
            var ran = new Random();
            model.Idhanghoa = "HH" + ran.Next(0000, 9999);
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
    }
}
