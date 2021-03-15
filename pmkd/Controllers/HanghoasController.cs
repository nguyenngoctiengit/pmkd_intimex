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
using pmkd.Models;

namespace pmkd.Controllers
{
    [Route("api/[controller]/[action]")]
    public class HanghoasController : Controller
    {
        private tradingsystem_blContext _context;

        public HanghoasController(tradingsystem_blContext context) {
            _context = context;
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

            // If you work with a large amount of data, consider specifying the PaginateViaPrimaryKey and PrimaryKey properties.
            // In this case, keys and data are loaded in separate queries. This can make the SQL execution plan more efficient.
            // Refer to the topic https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "Idhanghoa", "Mahang" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(hanghoas, loadOptions));
        }


        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Hanghoa();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Hanghoas.Add(model);
            await _context.SaveChangesAsync();

            return Json(result.Entity.Mahang);
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            var model = await _context.Hanghoas.FirstOrDefaultAsync(item => item.Idhanghoa == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(string key) {
            var model = await _context.Hanghoas.FirstOrDefaultAsync(item => item.Idhanghoa == key);

            _context.Hanghoas.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Hanghoa model, IDictionary values) {
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

            if(values.Contains(IDHANGHOA)) {
                model.Idhanghoa = Convert.ToString(values[IDHANGHOA]);
            }

            if(values.Contains(MAHANG)) {
                model.Mahang = Convert.ToString(values[MAHANG]);
            }

            if(values.Contains(TENHANG)) {
                model.Tenhang = Convert.ToString(values[TENHANG]);
            }

            if(values.Contains(TENHANGVAT)) {
                model.Tenhangvat = Convert.ToString(values[TENHANGVAT]);
            }

            if(values.Contains(MA_NHOM)) {
                model.MaNhom = Convert.ToString(values[MA_NHOM]);
            }

            if(values.Contains(DVT)) {
                model.Dvt = Convert.ToString(values[DVT]);
            }

            if(values.Contains(VAT)) {
                model.Vat = values[VAT] != null ? Convert.ToInt32(values[VAT]) : (int?)null;
            }

            if(values.Contains(SUDUNG)) {
                model.Sudung = values[SUDUNG] != null ? Convert.ToInt16(values[SUDUNG]) : (short?)null;
            }

            if(values.Contains(FULLNAME)) {
                model.Fullname = Convert.ToString(values[FULLNAME]);
            }

            if(values.Contains(QUICACH)) {
                model.Quicach = Convert.ToString(values[QUICACH]);
            }

            if(values.Contains(BAOBI)) {
                model.Baobi = Convert.ToString(values[BAOBI]);
            }

            if(values.Contains(KIEMDINH)) {
                model.Kiemdinh = Convert.ToString(values[KIEMDINH]);
            }

            if(values.Contains(VISIBLE)) {
                model.Visible = values[VISIBLE] != null ? Convert.ToBoolean(values[VISIBLE]) : (bool?)null;
            }

            if(values.Contains(ORDER_NHOM)) {
                model.OrderNhom = values[ORDER_NHOM] != null ? Convert.ToInt16(values[ORDER_NHOM]) : (short?)null;
            }

            if(values.Contains(DO_AM)) {
                model.DoAm = values[DO_AM] != null ? Convert.ToDecimal(values[DO_AM], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(HAT_DEN)) {
                model.HatDen = values[HAT_DEN] != null ? Convert.ToDecimal(values[HAT_DEN], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(TAP_CHAT)) {
                model.TapChat = values[TAP_CHAT] != null ? Convert.ToDecimal(values[TAP_CHAT], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(HAT_VO)) {
                model.HatVo = values[HAT_VO] != null ? Convert.ToDecimal(values[HAT_VO], CultureInfo.InvariantCulture) : (decimal?)null;
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}