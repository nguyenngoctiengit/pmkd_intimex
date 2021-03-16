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
    public class CtHdmbsController : Controller
    {
        private tradingsystem_blContext _context;

        public CtHdmbsController(tradingsystem_blContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions,string IDkhachhang) {
            var cthdmbs = from a in _context.KhachHangs
                          join b in _context.CustomerNorms on a.MaKhach equals b.Makhach
                          where a.Idkhach == IDkhachhang
                          select b;
            return Json(await DataSourceLoader.LoadAsync(cthdmbs, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new CtHdmb();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.CtHdmbs.Add(model);
            await _context.SaveChangesAsync();

            return Json(result.Entity.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(long key, string values) {
            var model = await _context.CtHdmbs.FirstOrDefaultAsync(item => item.Id == key);
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
        public async Task Delete(long key) {
            var model = await _context.CtHdmbs.FirstOrDefaultAsync(item => item.Id == key);

            _context.CtHdmbs.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(CtHdmb model, IDictionary values) {
            string ID_ROW = nameof(CtHdmb.IdRow);
            string SYSTEMREF = nameof(CtHdmb.Systemref);
            string REF = nameof(CtHdmb.Ref);
            string SOLUONG = nameof(CtHdmb.Soluong);
            string TRONGLUONG = nameof(CtHdmb.Trongluong);
            string MAHANG = nameof(CtHdmb.Mahang);
            string DVT = nameof(CtHdmb.Dvt);
            string GIACT = nameof(CtHdmb.Giact);
            string GIATT = nameof(CtHdmb.Giatt);
            string VAT = nameof(CtHdmb.Vat);
            string SIG = nameof(CtHdmb.Sig);
            string DIFF = nameof(CtHdmb.Diff);
            string STOPLOSS = nameof(CtHdmb.Stoploss);
            string GIACUOI = nameof(CtHdmb.Giacuoi);
            string NGAYFIX = nameof(CtHdmb.Ngayfix);
            string SOLOT = nameof(CtHdmb.Solot);
            string STATUS = nameof(CtHdmb.Status);
            string FNGAYFIX = nameof(CtHdmb.FNgayfix);
            string GIATHANG = nameof(CtHdmb.Giathang);
            string GIANAM = nameof(CtHdmb.Gianam);
            string DVT_THEO_HD = nameof(CtHdmb.DvtTheoHd);
            string GIA_THEO_HD = nameof(CtHdmb.GiaTheoHd);
            string ISRATE_EX = nameof(CtHdmb.IsrateEx);
            string CHI_PHI = nameof(CtHdmb.ChiPhi);
            string GIATHITRUONG = nameof(CtHdmb.Giathitruong);
            string MUCTHUONG = nameof(CtHdmb.Mucthuong);
            string CHUYEN_THANG = nameof(CtHdmb.ChuyenThang);
            string ID = nameof(CtHdmb.Id);
            string GIACT_SAU_CL = nameof(CtHdmb.GiactSauCl);
            string MATHANG_OLD = nameof(CtHdmb.MathangOld);
            string LOAI_BAO = nameof(CtHdmb.LoaiBao);
            string LOAI_BAO_OLD = nameof(CtHdmb.LoaiBaoOld);
            string GIA_OLD = nameof(CtHdmb.GiaOld);

            if(values.Contains(ID_ROW)) {
                model.IdRow = Convert.ToString(values[ID_ROW]);
            }

            if(values.Contains(SYSTEMREF)) {
                model.Systemref = Convert.ToString(values[SYSTEMREF]);
            }

            if(values.Contains(REF)) {
                model.Ref = Convert.ToString(values[REF]);
            }

            if(values.Contains(SOLUONG)) {
                model.Soluong = values[SOLUONG] != null ? Convert.ToInt32(values[SOLUONG]) : (int?)null;
            }

            if(values.Contains(TRONGLUONG)) {
                model.Trongluong = values[TRONGLUONG] != null ? Convert.ToDecimal(values[TRONGLUONG], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(MAHANG)) {
                model.Mahang = Convert.ToString(values[MAHANG]);
            }

            if(values.Contains(DVT)) {
                model.Dvt = Convert.ToString(values[DVT]);
            }

            if(values.Contains(GIACT)) {
                model.Giact = values[GIACT] != null ? Convert.ToDecimal(values[GIACT], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(GIATT)) {
                model.Giatt = values[GIATT] != null ? Convert.ToDecimal(values[GIATT], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(VAT)) {
                model.Vat = values[VAT] != null ? Convert.ToInt32(values[VAT]) : (int?)null;
            }

            if(values.Contains(SIG)) {
                model.Sig = Convert.ToString(values[SIG]);
            }

            if(values.Contains(DIFF)) {
                model.Diff = values[DIFF] != null ? Convert.ToDecimal(values[DIFF], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(STOPLOSS)) {
                model.Stoploss = values[STOPLOSS] != null ? Convert.ToDecimal(values[STOPLOSS], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(GIACUOI)) {
                model.Giacuoi = values[GIACUOI] != null ? Convert.ToDecimal(values[GIACUOI], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(NGAYFIX)) {
                model.Ngayfix = values[NGAYFIX] != null ? Convert.ToDateTime(values[NGAYFIX]) : (DateTime?)null;
            }

            if(values.Contains(SOLOT)) {
                model.Solot = values[SOLOT] != null ? Convert.ToDecimal(values[SOLOT], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(STATUS)) {
                model.Status = values[STATUS] != null ? Convert.ToBoolean(values[STATUS]) : (bool?)null;
            }

            if(values.Contains(FNGAYFIX)) {
                model.FNgayfix = values[FNGAYFIX] != null ? Convert.ToDateTime(values[FNGAYFIX]) : (DateTime?)null;
            }

            if(values.Contains(GIATHANG)) {
                model.Giathang = Convert.ToString(values[GIATHANG]);
            }

            if(values.Contains(GIANAM)) {
                model.Gianam = Convert.ToString(values[GIANAM]);
            }

            if(values.Contains(DVT_THEO_HD)) {
                model.DvtTheoHd = Convert.ToString(values[DVT_THEO_HD]);
            }

            if(values.Contains(GIA_THEO_HD)) {
                model.GiaTheoHd = values[GIA_THEO_HD] != null ? Convert.ToDecimal(values[GIA_THEO_HD], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(ISRATE_EX)) {
                model.IsrateEx = values[ISRATE_EX] != null ? Convert.ToBoolean(values[ISRATE_EX]) : (bool?)null;
            }

            if(values.Contains(CHI_PHI)) {
                model.ChiPhi = values[CHI_PHI] != null ? Convert.ToDecimal(values[CHI_PHI], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(GIATHITRUONG)) {
                model.Giathitruong = values[GIATHITRUONG] != null ? Convert.ToDecimal(values[GIATHITRUONG], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(MUCTHUONG)) {
                model.Mucthuong = values[MUCTHUONG] != null ? Convert.ToDecimal(values[MUCTHUONG], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(CHUYEN_THANG)) {
                model.ChuyenThang = values[CHUYEN_THANG] != null ? Convert.ToBoolean(values[CHUYEN_THANG]) : (bool?)null;
            }

            if(values.Contains(ID)) {
                model.Id = Convert.ToInt64(values[ID]);
            }

            if(values.Contains(GIACT_SAU_CL)) {
                model.GiactSauCl = Convert.ToDecimal(values[GIACT_SAU_CL], CultureInfo.InvariantCulture);
            }

            if(values.Contains(MATHANG_OLD)) {
                model.MathangOld = Convert.ToString(values[MATHANG_OLD]);
            }

            if(values.Contains(LOAI_BAO)) {
                model.LoaiBao = Convert.ToString(values[LOAI_BAO]);
            }

            if(values.Contains(LOAI_BAO_OLD)) {
                model.LoaiBaoOld = Convert.ToString(values[LOAI_BAO_OLD]);
            }

            if(values.Contains(GIA_OLD)) {
                model.GiaOld = Convert.ToString(values[GIA_OLD]);
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