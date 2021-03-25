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
using Microsoft.AspNetCore.Http;

namespace pmkd.Controllers
{
    [Route("api/[controller]/[action]")]
    public class HdmbsController : Controller
    {
        private tradingsystem_blContext _context;

        public HdmbsController(tradingsystem_blContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var hdmbs = _context.Hdmbs.Select(i => new {
                i.Macn,
                i.Systemref,
                i.Ref,
                i.Sohd,
                i.Trangthai,
                i.MuaBan,
                i.Makhach,
                i.Ngayky,
                i.Ngaygiao,
                i.Ngayhl,
                i.Ngaytl,
                i.Nguoitl,
                i.Nguoilam,
                i.Ghichu,
                i.Pakd,
                i.SoPakd,
                i.IsFix,
                i.Tiente,
                i.ThanhtoanId,
                i.Thanhtoan,
                i.Ngaylam,
                i.IntKy,
                i.ClientKy,
                i.Docstatus,
                i.TrangthaiGhep,
                i.TienUngHd,
                i.TienUngTt,
                i.HdcmuonId,
                i.SoHdcmuon,
                i.DiaDiemGiaoHang,
                i.IsNoKhoDoi,
                i.TypeKd,
                i.VanChuyen,
                i.NgayTraPhaitra,
                i.Dichvu,
                i.Tenfull
            });

            // If you work with a large amount of data, consider specifying the PaginateViaPrimaryKey and PrimaryKey properties.
            // In this case, keys and data are loaded in separate queries. This can make the SQL execution plan more efficient.
            // Refer to the topic https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "Systemref" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(hdmbs, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Hdmb();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Hdmbs.Add(model);
            await _context.SaveChangesAsync();

            return Json(result.Entity.Systemref);
        }

        [HttpPut]
        public async Task<IActionResult> Put(string key, string values) {
            var model = await _context.Hdmbs.FirstOrDefaultAsync(item => item.Systemref == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));
            var hdchomuon = (from a in _context.Hdmbs where a.MuaBan == "CMUON" select a).ToList();
            if (model.HdcmuonId == null)
            {
                model.HdcmuonId = "";
                model.SoHdcmuon = "";
            }
            else
            {
                foreach (var item in hdchomuon)
                {
                    if (item.Systemref == model.HdcmuonId)
                    {
                        model.HdcmuonId = item.Systemref;
                        model.SoHdcmuon = (from a in _context.Hdmbs where model.HdcmuonId == item.Systemref select a.Sohd).FirstOrDefault().ToString();
                    }
                }
            }
            model.Macn = HttpContext.Session.GetString("UnitName");
            model.TrangthaiGhep = true;
            _context.Hdmbs.Update(model);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task <IActionResult> Delete(string key) {
            var model = await _context.Hdmbs.FirstOrDefaultAsync(item => item.Systemref == key);
            var flag_stock = false;
            var flag_fix = false;
            var list_stock = _context.InputStocks.ToList();
            var list_fix = _context.Fixgia.ToList();
            foreach (var item in list_stock)
            {
                if (item.ContractId == model.Systemref)
                {
                    flag_stock = true;
                }
            }
            foreach (var item in list_fix)
            {
                if (item.Systemref == model.Systemref)
                {
                    flag_fix = true;
                }
            }
            if (flag_stock == true)
            {
                return BadRequest("Hợp đồng đã giao hàng, không fix đc");
            }
            if (flag_fix == true)
            {
                return BadRequest("Hợp đồng đã fix giá, không hủy đc");
            }
            model.Trangthai = 2;
            _context.Hdmbs.Update(model);
            await _context.SaveChangesAsync();
            return Ok();
        }


        private void PopulateModel(Hdmb model, IDictionary values) {
            string MACN = nameof(Hdmb.Macn);
            string SYSTEMREF = nameof(Hdmb.Systemref);
            string REF = nameof(Hdmb.Ref);
            string SOHD = nameof(Hdmb.Sohd);
            string TRANGTHAI = nameof(Hdmb.Trangthai);
            string MUA_BAN = nameof(Hdmb.MuaBan);
            string MAKHACH = nameof(Hdmb.Makhach);
            string NGAYKY = nameof(Hdmb.Ngayky);
            string NGAYGIAO = nameof(Hdmb.Ngaygiao);
            string NGAYHL = nameof(Hdmb.Ngayhl);
            string NGAYTL = nameof(Hdmb.Ngaytl);
            string NGUOITL = nameof(Hdmb.Nguoitl);
            string NGUOILAM = nameof(Hdmb.Nguoilam);
            string GHICHU = nameof(Hdmb.Ghichu);
            string PAKD = nameof(Hdmb.Pakd);
            string SO_PAKD = nameof(Hdmb.SoPakd);
            string IS_FIX = nameof(Hdmb.IsFix);
            string TIENTE = nameof(Hdmb.Tiente);
            string THANHTOAN_ID = nameof(Hdmb.ThanhtoanId);
            string THANHTOAN = nameof(Hdmb.Thanhtoan);
            string NGAYLAM = nameof(Hdmb.Ngaylam);
            string INT_KY = nameof(Hdmb.IntKy);
            string CLIENT_KY = nameof(Hdmb.ClientKy);
            string DOCSTATUS = nameof(Hdmb.Docstatus);
            string TRANGTHAI_GHEP = nameof(Hdmb.TrangthaiGhep);
            string TIEN_UNG_HD = nameof(Hdmb.TienUngHd);
            string TIEN_UNG_TT = nameof(Hdmb.TienUngTt);
            string HDCMUON_ID = nameof(Hdmb.HdcmuonId);
            string SO_HDCMUON = nameof(Hdmb.SoHdcmuon);
            string DIA_DIEM_GIAO_HANG = nameof(Hdmb.DiaDiemGiaoHang);
            string IS_NO_KHO_DOI = nameof(Hdmb.IsNoKhoDoi);
            string TYPE_KD = nameof(Hdmb.TypeKd);
            string VAN_CHUYEN = nameof(Hdmb.VanChuyen);
            string NGAY_TRA_PHAITRA = nameof(Hdmb.NgayTraPhaitra);
            string DICHVU = nameof(Hdmb.Dichvu);
            string TENFULL = nameof(Hdmb.Tenfull);

            if(values.Contains(MACN)) {
                model.Macn = Convert.ToString(values[MACN]);
            }

            if(values.Contains(SYSTEMREF)) {
                model.Systemref = Convert.ToString(values[SYSTEMREF]);
            }

            if(values.Contains(REF)) {
                model.Ref = Convert.ToString(values[REF]);
            }

            if(values.Contains(SOHD)) {
                model.Sohd = Convert.ToString(values[SOHD]);
            }

            if(values.Contains(TRANGTHAI)) {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToInt32(values[TRANGTHAI]) : (int?)null;
            }

            if(values.Contains(MUA_BAN)) {
                model.MuaBan = Convert.ToString(values[MUA_BAN]);
            }

            if(values.Contains(MAKHACH)) {
                model.Makhach = Convert.ToString(values[MAKHACH]);
            }

            if(values.Contains(NGAYKY)) {
                model.Ngayky = values[NGAYKY] != null ? Convert.ToDateTime(values[NGAYKY]) : (DateTime?)null;
            }

            if(values.Contains(NGAYGIAO)) {
                model.Ngaygiao = values[NGAYGIAO] != null ? Convert.ToDateTime(values[NGAYGIAO]) : (DateTime?)null;
            }

            if(values.Contains(NGAYHL)) {
                model.Ngayhl = values[NGAYHL] != null ? Convert.ToDateTime(values[NGAYHL]) : (DateTime?)null;
            }

            if(values.Contains(NGAYTL)) {
                model.Ngaytl = values[NGAYTL] != null ? Convert.ToDateTime(values[NGAYTL]) : (DateTime?)null;
            }

            if(values.Contains(NGUOITL)) {
                model.Nguoitl = Convert.ToString(values[NGUOITL]);
            }

            if(values.Contains(NGUOILAM)) {
                model.Nguoilam = Convert.ToString(values[NGUOILAM]);
            }

            if(values.Contains(GHICHU)) {
                model.Ghichu = Convert.ToString(values[GHICHU]);
            }

            if(values.Contains(PAKD)) {
                model.Pakd = values[PAKD] != null ? Convert.ToBoolean(values[PAKD]) : (bool?)null;
            }

            if(values.Contains(SO_PAKD)) {
                model.SoPakd = Convert.ToString(values[SO_PAKD]);
            }

            if(values.Contains(IS_FIX)) {
                model.IsFix = values[IS_FIX] != null ? Convert.ToBoolean(values[IS_FIX]) : (bool?)null;
            }

            if(values.Contains(TIENTE)) {
                model.Tiente = Convert.ToString(values[TIENTE]);
            }

            if(values.Contains(THANHTOAN_ID)) {
                model.ThanhtoanId = values[THANHTOAN_ID] != null ? Convert.ToInt64(values[THANHTOAN_ID]) : (long?)null;
            }

            if(values.Contains(THANHTOAN)) {
                model.Thanhtoan = Convert.ToString(values[THANHTOAN]);
            }

            if(values.Contains(NGAYLAM)) {
                model.Ngaylam = values[NGAYLAM] != null ? Convert.ToDateTime(values[NGAYLAM]) : (DateTime?)null;
            }

            if(values.Contains(INT_KY)) {
                model.IntKy = Convert.ToString(values[INT_KY]);
            }

            if(values.Contains(CLIENT_KY)) {
                model.ClientKy = Convert.ToString(values[CLIENT_KY]);
            }

            if(values.Contains(DOCSTATUS)) {
                model.Docstatus = values[DOCSTATUS] != null ? Convert.ToBoolean(values[DOCSTATUS]) : (bool?)null;
            }

            if(values.Contains(TRANGTHAI_GHEP)) {
                model.TrangthaiGhep = values[TRANGTHAI_GHEP] != null ? Convert.ToBoolean(values[TRANGTHAI_GHEP]) : (bool?)null;
            }

            if(values.Contains(TIEN_UNG_HD)) {
                model.TienUngHd = Convert.ToDecimal(values[TIEN_UNG_HD], CultureInfo.InvariantCulture);
            }

            if(values.Contains(TIEN_UNG_TT)) {
                model.TienUngTt = Convert.ToDecimal(values[TIEN_UNG_TT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(HDCMUON_ID)) {
                model.HdcmuonId = Convert.ToString(values[HDCMUON_ID]);
            }

            if(values.Contains(SO_HDCMUON)) {
                model.SoHdcmuon = Convert.ToString(values[SO_HDCMUON]);
            }

            if(values.Contains(DIA_DIEM_GIAO_HANG)) {
                model.DiaDiemGiaoHang = Convert.ToString(values[DIA_DIEM_GIAO_HANG]);
            }

            if(values.Contains(IS_NO_KHO_DOI)) {
                model.IsNoKhoDoi = Convert.ToBoolean(values[IS_NO_KHO_DOI]);
            }

            if(values.Contains(TYPE_KD)) {
                model.TypeKd = Convert.ToInt32(values[TYPE_KD]);
            }

            if(values.Contains(VAN_CHUYEN)) {
                model.VanChuyen = Convert.ToString(values[VAN_CHUYEN]);
            }

            if(values.Contains(NGAY_TRA_PHAITRA)) {
                model.NgayTraPhaitra = values[NGAY_TRA_PHAITRA] != null ? Convert.ToDateTime(values[NGAY_TRA_PHAITRA]) : (DateTime?)null;
            }

            if(values.Contains(DICHVU)) {
                model.Dichvu = values[DICHVU] != null ? Convert.ToBoolean(values[DICHVU]) : (bool?)null;
            }

            if(values.Contains(TENFULL)) {
                model.Tenfull = Convert.ToString(values[TENFULL]);
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