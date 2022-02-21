﻿using Application.Parameter;
using Data.Models.SignalR;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
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

namespace Intimex_project.Controllers
{
    public class HopdongController : Controller
    {
        public DateTime NgayKy;
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public HopdongController()
        {
        }
        //Index
        public IActionResult Index()
        {
            return View();
        }
        //View HDMB
        [HttpGet]
        public object GetHopdong(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Hdmbs
                       select new
                       {
                           a.Systemref,
                           a.Ngaylam,
                           a.Sohd,
                           Trangthai = a.Trangthai == 2 ? "Hủy" : a.Trangthai == 1 ? "TH" : "TL",
                           a.MuaBan
                       }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetCt_HDMB(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.CtHdmbs join b in _context.Hanghoas on a.Mahang equals b.Mahang where a.Systemref == "HD00037387"
                        select new
                        {
                            a.IdRow,
                            a.Systemref,
                            a.Mahang,
                            Tenhang = b.Tenhang,
                            a.Soluong,
                            a.Trongluong,
                            a.Dvt,
                            a.Vat,
                            a.Giact,
                            a.Giatt,
                            a.Solot,
                            a.Giathang,
                            a.Gianam,
                            a.Sig,
                            a.Diff,
                            a.FNgayfix,
                            a.Stoploss,
                            MaNhom = b.MaNhom,
                            a.Giathitruong,
                            a.Mucthuong
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public IActionResult hdmb()
        {
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
