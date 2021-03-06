﻿using DevExtreme.AspNet.Data;
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
    public class HopdongController : Controller
    {
        public DateTime NgayKy;
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public HopdongController(tradingsystem_blContext context)
        {
            _context = context;
        }
        //Index
        public IActionResult Index()
        {
            return View();
        }
        //View HDMB
        public IActionResult hdmb()
        {
            ViewBag.signer = _context.Signers.ToList();
            ViewBag.hdmb = _context.Hdmbs.Select(i => i.IntKy);
            return View("hdmb");
        }
        [Route("hopdong/hopdong/themhopdong")]
        //view thêm hợp đồng
        public IActionResult themhopdong()
        {
            ViewBag.signer = _context.Signers.ToList();
            ViewBag.hh = _context.Hanghoas.ToList();
            ViewBag.kh = _context.KhachHangs.ToList();
            var uniname = HttpContext.Session.GetString("UnitName");
            ViewBag.intky = _context.Signers.Where(a => a.MaKhach == uniname).ToList();
            ViewBag.thanhtoan = _context.PortfolioPayments.ToList();
            ViewBag.diadiemgiaohang = _context.HdmbGiaohangs.ToList();
            ViewBag.hdchomuon = _context.Hdmbs.Where(a => a.MuaBan == "CMUON").ToList();
            ViewBag.client = _context.Signers.ToList();
            
            return View("themhopdong");
        }
        // function thêm hợp đồng 
        [HttpPost]
        public IActionResult themhopdong1(Hdmb hdmb)
        {
            
            var hdchomuon = (from a in _context.Hdmbs where a.MuaBan == "CMUON" select a).ToList();
            var phuongthucthanhtoan = (from a in _context.PortfolioPayments select a).ToList();
            hdmb.Macn = HttpContext.Session.GetString("UnitName");
            hdmb.Trangthai = 1;
            hdmb.Nguoilam = HttpContext.Session.GetString("userId");
            foreach (var item in phuongthucthanhtoan)
            {
                if (item.Id == hdmb.ThanhtoanId)
                {
                    hdmb.Thanhtoan = (from a in _context.PortfolioPayments where hdmb.ThanhtoanId == item.Id select a.Matt).FirstOrDefault();
                }
            }
            if (hdmb.HdcmuonId == null)
            {
                hdmb.HdcmuonId = "";
                hdmb.SoHdcmuon = "";
            }
            else
            {
                foreach (var item in hdchomuon)
                {
                    if (item.Systemref == hdmb.HdcmuonId)
                    {
                        hdmb.HdcmuonId = item.Systemref;
                        hdmb.SoHdcmuon = (from a in _context.Hdmbs where hdmb.HdcmuonId == item.Systemref select a.Sohd).FirstOrDefault().ToString();
                    }
                }
            }
            hdmb.TrangthaiGhep = true;
            hdmb.Ngaylam = DateTime.Now;
            _context.Hdmbs.Add(hdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        [Route("hopdong/hopdong/addcthdoutright/{id?}")]
        //View thêm chi tiết hợp đồng outright
        public IActionResult addcthdoutright(string id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault();
            ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            return View("addcthdoutright");
        }
        //function thêm chi tiết hợp đồng outright
        [HttpPost]
        public IActionResult addcthdoutright1(CtHdmb ctHdmb)
        {
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        //View cập nhật chi tiết hợp đồng outright
        public IActionResult updatecthdoutright(long id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs
                                join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                                where b.Id == id
                                select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs
                             join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                             where b.Id == id
                             select a.Ref).FirstOrDefault().Trim();
            ViewBag.sohd = (from a in _context.Hdmbs
                            join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                            where b.Id == id
                            select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            var cthdmb = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            return View("updatecthdoutright",cthdmb);
        }
        //function cập nhật chi tiết hợp đồng outright
        [HttpPost]
        public IActionResult updatecthdoutright1(CtHdmb ctHdmb)
        {
            ctHdmb.Giatt = 0;
            _context.CtHdmbs.Update(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "update chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        [Route("hopdong/hopdong/deletecthd/{id?}")]
        //function xóa chi tiết hợp đồng
        public IActionResult deletecthd(long id)
        {
           
            var del_item = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            var flag_fix = false;
            var list_fix = _context.Fixgia.ToList();
            if (del_item != null)
            {
                foreach (var item in list_fix)
                {
                    if (del_item.Systemref == item.Systemref)
                    {
                        flag_fix = true;
                    }
                }
            }
            if (flag_fix == true)
            {
                
                TempData["alertMessage"] = "hợp đồng đã fix giá, không xóa đc";
                return RedirectToAction("hdmb");

            }
            else
            {
                _context.CtHdmbs.Remove(del_item);
                _context.SaveChanges();
                TempData["alertMessage"] = "xóa chi tiết hợp đồng mua bán thành công";
                return RedirectToAction("hdmb");
            }
        }
        [Route("hopdong/hopdong/addcthd/{id?}")]
        //View thêm chi tiết hợp đồng
        public IActionResult addcthd(string id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs where a.Systemref == id select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs where a.Systemref == id select a.Ref).FirstOrDefault().Trim();
            ViewBag.sohd = (from a in _context.Hdmbs where a.Systemref == id select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            return View("addcthd");
        }
        [HttpPost]
        //function thêm chi tiết hợp đồng
        public IActionResult functionaddcthd(CtHdmb ctHdmb)
        {
            int t = 0;
            if (ctHdmb.FNgayfix == null)
            {
                ctHdmb.FNgayfix = new DateTime(1990, 01, 01);
            }
            if (int.TryParse(ctHdmb.Stoploss.ToString(), out t) == false && t < 0)
            {
                TempData["alertMessage"] = "stop loss nhập không đúng";
                return RedirectToAction("hdmb");
            }
            if (ctHdmb.Giathang != "1" && ctHdmb.Giathang != "3" && ctHdmb.Giathang != "5" && ctHdmb.Giathang != "7" && ctHdmb.Giathang != "9" && ctHdmb.Giathang != "11")
            {
                TempData["alertMessage"] = "giá tháng nhập không đúng";
                return RedirectToAction("hdmb");
            }
            if (int.TryParse(ctHdmb.Gianam, out t) == false && t < NgayKy.Year)
            {
                TempData["alertMessage"] = "giá năm nhập không đúng";
                return RedirectToAction("hdmb");
            }
            if (ctHdmb.FNgayfix.Value.Year > t || (ctHdmb.FNgayfix.Value.Month > int.Parse(ctHdmb.Giathang) && ctHdmb.FNgayfix.Value.Year == t))
            {
                TempData["alertMessage"] = "ngày chốt cuối nhập không đúng";
                return RedirectToAction("hdmb");
            }
            ctHdmb.Dvt = "KGS";
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        //View update chi tiết hợp đồng
        public IActionResult updatecthd(long id)
        {
            ViewBag.systemId = (from a in _context.Hdmbs
                                join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                                where b.Id == id
                                select a.Systemref).FirstOrDefault();
            ViewBag.refid = (from a in _context.Hdmbs
                             join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                             where b.Id == id
                             select a.Ref).FirstOrDefault().Trim();
            ViewBag.sohd = (from a in _context.Hdmbs
                            join b in _context.CtHdmbs on a.Systemref equals b.Systemref
                            where b.Id == id
                            select a.Sohd).FirstOrDefault();
            ViewBag.hh = (from a in _context.Hanghoas select a).ToList();
            ViewBag.id = id;
            var cthdmb = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            return View("updatecthd", cthdmb);
        }
        //function update chi tiết hợp đồng
        [HttpPost]
        public IActionResult updatecthd(CtHdmb ctHdmb,long id)
        {
            var item = _context.CtHdmbs.Where(a => a.Id == id).FirstOrDefault();
            item.Giact = 0;
            item.Dvt = "KGS";
            item.Giatt = 0;
            item.DvtTheoHd = "KGS";
            _context.Update(item);
            _context.SaveChangesAsync();
            TempData["alertMessage"] = "cập nhật chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        //lấy dữ liệu hợp đồng mua bán
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
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

            return Json(await DataSourceLoader.LoadAsync(hdmbs, loadOptions));
        }
        //lấy dữ liệu chi tiết hợp đồng mua bán
        [HttpGet]
        public async Task<IActionResult> Getcthdmb(DataSourceLoadOptions loadOptions, string id)
        {
            var cthdmbs = from a in _context.CtHdmbs
                          join b in _context.Hanghoas on a.Mahang equals b.Mahang

                            into ps
                          from c in ps.DefaultIfEmpty()
                          join d in _context.Hdmbs on a.Systemref equals d.Systemref
                          where a.Systemref == id
                          select new
                          {
                              a.IdRow,
                              a.Systemref,
                              a.Ref,
                              a.Soluong,
                              a.Trongluong,
                              a.Mahang,
                              a.Dvt,
                              a.Giact,
                              a.Giatt,
                              a.Vat,
                              a.Sig,
                              a.Diff,
                              a.Stoploss,
                              a.Giacuoi,
                              a.Ngayfix,
                              a.Solot,
                              a.Status,
                              a.FNgayfix,
                              a.Giathang,
                              a.Gianam,
                              a.DvtTheoHd,
                              a.GiaTheoHd,
                              a.IsrateEx,
                              a.ChiPhi,
                              a.Giathitruong,
                              a.Mucthuong,
                              a.ChuyenThang,
                              a.Id,
                              a.GiactSauCl,
                              a.MathangOld,
                              a.LoaiBao,
                              a.LoaiBaoOld,
                              a.GiaOld,
                              tenhang = c.Tenhang,
                              isfix = d.IsFix

                          };
            return Json(await DataSourceLoader.LoadAsync(cthdmbs, loadOptions));
        }
        //update hợp đồng mua bán
        [HttpPut]
        public async Task<IActionResult> Put(string key, string values)
        {
            var model = await _context.Hdmbs.FirstOrDefaultAsync(item => item.Systemref == key);
            if (model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if (!TryValidateModel(model))
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
            var ctthanhtoan = (_context.PortfolioPayments.Where(a => a.Id == model.ThanhtoanId).Select(a => a.Matt)).FirstOrDefault();
            model.Thanhtoan = ctthanhtoan;
            model.Macn = HttpContext.Session.GetString("UnitName");
            model.TrangthaiGhep = true;
            _context.Hdmbs.Update(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
        //xóa hợp đồng mua bán
        [HttpDelete]
        public async Task<IActionResult> Delete(string key)
        {
            var model = await _context.Hdmbs.FirstOrDefaultAsync(item => item.Systemref == key);
            var flag_stock = false;
            var flag_fix = false;
            var list_stock = _context.InputStocks.ToList();
            var list_fix = _context.Fixgia.ToList();
            foreach (var item in list_stock)
            {
                if (item.ContractIdSource == model.Systemref)
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
                return BadRequest("Hợp đồng đã giao hàng, không hủy đc");
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


        private void PopulateModel(Hdmb model, IDictionary values)
        {
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

            if (values.Contains(MACN))
            {
                model.Macn = Convert.ToString(values[MACN]);
            }

            if (values.Contains(SYSTEMREF))
            {
                model.Systemref = Convert.ToString(values[SYSTEMREF]);
            }

            if (values.Contains(REF))
            {
                model.Ref = Convert.ToString(values[REF]);
            }

            if (values.Contains(SOHD))
            {
                model.Sohd = Convert.ToString(values[SOHD]);
            }

            if (values.Contains(TRANGTHAI))
            {
                model.Trangthai = values[TRANGTHAI] != null ? Convert.ToInt32(values[TRANGTHAI]) : (int?)null;
            }

            if (values.Contains(MUA_BAN))
            {
                model.MuaBan = Convert.ToString(values[MUA_BAN]);
            }

            if (values.Contains(MAKHACH))
            {
                model.Makhach = Convert.ToString(values[MAKHACH]);
            }

            if (values.Contains(NGAYKY))
            {
                model.Ngayky = values[NGAYKY] != null ? Convert.ToDateTime(values[NGAYKY]) : (DateTime?)null;
            }

            if (values.Contains(NGAYGIAO))
            {
                model.Ngaygiao = values[NGAYGIAO] != null ? Convert.ToDateTime(values[NGAYGIAO]) : (DateTime?)null;
            }

            if (values.Contains(NGAYHL))
            {
                model.Ngayhl = values[NGAYHL] != null ? Convert.ToDateTime(values[NGAYHL]) : (DateTime?)null;
            }

            if (values.Contains(NGAYTL))
            {
                model.Ngaytl = values[NGAYTL] != null ? Convert.ToDateTime(values[NGAYTL]) : (DateTime?)null;
            }

            if (values.Contains(NGUOITL))
            {
                model.Nguoitl = Convert.ToString(values[NGUOITL]);
            }

            if (values.Contains(NGUOILAM))
            {
                model.Nguoilam = Convert.ToString(values[NGUOILAM]);
            }

            if (values.Contains(GHICHU))
            {
                model.Ghichu = Convert.ToString(values[GHICHU]);
            }

            if (values.Contains(PAKD))
            {
                model.Pakd = values[PAKD] != null ? Convert.ToBoolean(values[PAKD]) : (bool?)null;
            }

            if (values.Contains(SO_PAKD))
            {
                model.SoPakd = Convert.ToString(values[SO_PAKD]);
            }

            if (values.Contains(IS_FIX))
            {
                model.IsFix = values[IS_FIX] != null ? Convert.ToBoolean(values[IS_FIX]) : (bool?)null;
            }

            if (values.Contains(TIENTE))
            {
                model.Tiente = Convert.ToString(values[TIENTE]);
            }

            if (values.Contains(THANHTOAN_ID))
            {
                model.ThanhtoanId = values[THANHTOAN_ID] != null ? Convert.ToInt64(values[THANHTOAN_ID]) : (long?)null;
            }

            if (values.Contains(THANHTOAN))
            {
                model.Thanhtoan = Convert.ToString(values[THANHTOAN]);
            }

            if (values.Contains(NGAYLAM))
            {
                model.Ngaylam = values[NGAYLAM] != null ? Convert.ToDateTime(values[NGAYLAM]) : (DateTime?)null;
            }

            if (values.Contains(INT_KY))
            {
                model.IntKy = Convert.ToString(values[INT_KY]);
            }

            if (values.Contains(CLIENT_KY))
            {
                model.ClientKy = Convert.ToString(values[CLIENT_KY]);
            }

            if (values.Contains(DOCSTATUS))
            {
                model.Docstatus = values[DOCSTATUS] != null ? Convert.ToBoolean(values[DOCSTATUS]) : (bool?)null;
            }

            if (values.Contains(TRANGTHAI_GHEP))
            {
                model.TrangthaiGhep = values[TRANGTHAI_GHEP] != null ? Convert.ToBoolean(values[TRANGTHAI_GHEP]) : (bool?)null;
            }

            if (values.Contains(TIEN_UNG_HD))
            {
                model.TienUngHd = Convert.ToDecimal(values[TIEN_UNG_HD], CultureInfo.InvariantCulture);
            }

            if (values.Contains(TIEN_UNG_TT))
            {
                model.TienUngTt = Convert.ToDecimal(values[TIEN_UNG_TT], CultureInfo.InvariantCulture);
            }

            if (values.Contains(HDCMUON_ID))
            {
                model.HdcmuonId = Convert.ToString(values[HDCMUON_ID]);
            }

            if (values.Contains(SO_HDCMUON))
            {
                model.SoHdcmuon = Convert.ToString(values[SO_HDCMUON]);
            }

            if (values.Contains(DIA_DIEM_GIAO_HANG))
            {
                model.DiaDiemGiaoHang = Convert.ToString(values[DIA_DIEM_GIAO_HANG]);
            }

            if (values.Contains(IS_NO_KHO_DOI))
            {
                model.IsNoKhoDoi = Convert.ToBoolean(values[IS_NO_KHO_DOI]);
            }

            if (values.Contains(TYPE_KD))
            {
                model.TypeKd = Convert.ToInt32(values[TYPE_KD]);
            }

            if (values.Contains(VAN_CHUYEN))
            {
                model.VanChuyen = Convert.ToString(values[VAN_CHUYEN]);
            }

            if (values.Contains(NGAY_TRA_PHAITRA))
            {
                model.NgayTraPhaitra = values[NGAY_TRA_PHAITRA] != null ? Convert.ToDateTime(values[NGAY_TRA_PHAITRA]) : (DateTime?)null;
            }

            if (values.Contains(DICHVU))
            {
                model.Dichvu = values[DICHVU] != null ? Convert.ToBoolean(values[DICHVU]) : (bool?)null;
            }

            if (values.Contains(TENFULL))
            {
                model.Tenfull = Convert.ToString(values[TENFULL]);
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

        //--------------------------------------Phương án kinh doanh--------------------------------------

        public IActionResult pakd()
        {
            return View("pakd/pakd");
        }
        public async Task<IActionResult> getpakd(DataSourceLoadOptions loadOptions)
        {
            var pakd = _context.Plans.Select(i => new {
                i.SystemId,
                i.SoPa,
                i.NgayPa,
                i.DoiTacBan,
                i.DanhGiaBan,
                i.HdBan,
                i.DoiTacMua,
                i.DanhGiaMua,
                i.HdMua,
                i.HangHoa,
                i.Dvt,
                i.Trongluong,
                i.TyGia,
                i.NguonVon,
                i.LaiSuat,
                i.Songay,
                i.Dieukiengiao,
                i.Ngaygiao,
                i.ThanhToanMua,
                i.ThanhToanBan,
                i.GiaBan,
                i.GiaBanU,
                i.Tienteban,
                i.TriGiaBan,
                i.TriGiaBanU,
                i.GiaMua,
                i.GiaMuaU,
                i.Tientemua,
                i.TriGiaMua,
                i.TriGiaMuaU,
                i.LaiGop,
                i.Tongchiphi,
                i.CpVanTai,
                i.CpHoaHong,
                i.CpGiaoNhan,
                i.CpLaiVay,
                i.CpQuanLy,
                i.CpKhac,
                i.LaiRong,
                i.Duyet,
                i.Macn,
                i.TrangthaiGhep,
                i.Chenhlechmuaban,
                i.Tientechenhlech,
                i.Isfix,
                i.GhiChu,
                i.Trangthai,
                i.DienGiaiNguonVon,
                i.CtTinhLaiVay,
                i.TienTeGn,
                i.TienTeHh,
                i.TienTeVc,
                i.CangGiaoHang,
                i.NoiNhanHang,
                i.CpCuocTau,
                i.CpBaoHiem,
                i.CpThc,
                i.CpKhuTrung,
                i.TienTeQly,
                i.TienTeCuocTau,
                i.TienTeBaoHiem,
                i.TienTeThc,
                i.TienTeKhuTrung,
                i.TienTeLaiVay,
                i.TienTeKhac,
                i.SoCont,
                i.DvtCt,
                i.DvtVcnd,
                i.DvtBh,
                i.DvtHh,
                i.DvtGn,
                i.DvtGd,
                i.DvtThc,
                i.DvtKt,
                i.DvtLv,
                i.DvtKhac,
                i.IsNew,
                i.LoiNhuanSx,
                i.ChiPhiSx,

            });

            return Json(await DataSourceLoader.LoadAsync(pakd, loadOptions));
        }
        public IActionResult test()
        {
            return View();
        }
    }
}
