using Application.AutoId;
using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class PlansController : Controller
    {
        double QuantityMaxHD = 0;
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPlans(string id)
        {
            var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            if (checkHDHasPA(id) == 1)
            {
                TempData["alertMessage"] = "Hợp đồng bán này đã có phương án, không thể thực hiện ghép phương án";
                return RedirectToAction("hdmb", "Hopdong");
            }
            else if (checkHDHasPA(id) == 2)
            {
                TempData["alertMessage"] = "Hợp đồng mua này đã ghép hết trọng lượng, không thể thực hiện ghép phương án";
                return RedirectToAction("hdmb", "Hopdong");
            }
            if (hdmb.MuaBan == "MUA")
            {
                ViewBag.checkMuaBan = "MUA";
            }
            else
            {
                ViewBag.checkMuaBan = "BAN";
            }
            var TrongLuongHD = _context.CtHdmbs.Where(a => a.Systemref == hdmb.Systemref).Sum(a => a.Trongluong) == 0 ? 0 : _context.CtHdmbs.Where(a => a.Systemref == hdmb.Systemref).Sum(a => a.Trongluong);
            ViewBag.SystemRef = hdmb.Systemref;
            ViewBag.Sohd = hdmb.Sohd;
            ViewBag.MaKhach = hdmb.Makhach;
            ViewBag.TrongLuong = TrongLuongHD;
            ViewBag.MuaBan = hdmb.MuaBan;
            ViewBag.TrongLuongDuocGhep = TrongLuongHD - (decimal)_context.PairedPlans.Where(a => a.ContracId == id).Sum(a => a.Trongluong) != 0 ? (decimal)_context.PairedPlans.Where(a => a.ContracId == id).Sum(a => a.Trongluong) : 0;
            var TrongLuongDuocGhep = TrongLuongHD - (decimal)_context.PairedPlans.Where(a => a.ContracId == id).Sum(a => a.Trongluong) != 0 ? (decimal)_context.PairedPlans.Where(a => a.ContracId == id).Sum(a => a.Trongluong) : 0;
            QuantityMaxHD = (double)TrongLuongHD * (double)5 / 100 + (double)TrongLuongDuocGhep;
            return View("AddPlans");
            
        }
        public int checkHDHasPA(string id)
        {
            int check = 0;
            var itemCheck = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            if (itemCheck.MuaBan == "BAN")
            {
                if (_context.PairedPlans.Any(a => a.ContracId == id))
                {
                    check = 1;
                }
                else
                {
                    check = 0;
                }
            }
            else if (itemCheck.MuaBan == "MUA")
            {
                if (_context.PairedPlans.Any(a => a.ContracId == id) && (_context.CtHdmbs.Where(a => a.Systemref == id).Sum(a => a.Trongluong) <= (decimal)(_context.PairedPlans.Where(a => a.ContracId == id).Sum(a => a.Trongluong))))
                {
                    check = 2;
                }
                else
                {
                    check = 0;
                }
            }
            return check;
        }
        [HttpGet]
        public object GetPlansToAddContract(string id, DataSourceLoadOptions loadOptions)
        {
            
            var Sp = "exec [dbo].[UdscGhepPAKD] @SoPA = '',@macn = '"+ HttpContext.Session.GetString("UnitName") + "'";
            var item = _context.Sp_GetPlans.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetHDMB(string id, DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec [dbo].[UdscGhepPAKD];2 @SoHD = ''," +
                       "@macn = '" + HttpContext.Session.GetString("UnitName") + "'," +
                       "@mua_ban = '" + id + "'";
            var item = _context.Sp_GetHDMB_Plans.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object getPlans(string id,DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.PairedPlans
                        join b in _context.Hdmbs on a.ContracId equals b.Systemref
                        where a.PlansId == id && b.MuaBan == "MUA"
                        select new
                        {
                            a.PlansId,
                            a.ContracId,
                            a.SystemId,
                            a.Trongluong,
                            a.Macn,
                            b.Systemref,
                            b.Ref,
                            b.Sohd,
                            b.Trangthai,
                            b.MuaBan,
                            b.Makhach,
                            b.Ngayky,
                            b.Ngaygiao,
                            b.Ngayhl,
                            b.Ngaytl,
                            b.Nguoitl,
                            b.Nguoilam,
                            b.Ghichu,
                            b.Pakd,
                            b.SoPakd,
                            b.IsFix,
                            b.Tiente,
                            b.ThanhtoanId,
                            b.Thanhtoan,
                            b.Ngaylam,
                            b.IntKy,
                            b.ClientKy,
                            b.Docstatus,
                            b.TrangthaiGhep,
                            b.TienUngHd,
                            b.TienUngTt,
                            b.HdcmuonId,
                            b.SoHdcmuon,
                            b.DiaDiemGiaoHang,
                            b.IsNoKhoDoi,
                            b.TypeKd,
                            b.VanChuyen,
                            b.NgayTraPhaitra,
                            b.Tenfull
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public bool CheckPAHasHDBan(string id)
        {
            var item_check = (from a in _context.Hdmbs join b in _context.PairedPlans on a.Systemref equals b.ContracId where a.MuaBan == "BAN" && b.PlansId == id select a).ToList();
            if (item_check.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost]
        public IActionResult Fill_data_plans(string SystemId,string Id_HDMB)
        {
            var HDMB = _context.Hdmbs.Where(a => a.Systemref == Id_HDMB).FirstOrDefault();
            if (HDMB.MuaBan == "BAN" && CheckPAHasHDBan(SystemId) == true)
            {
                return Json(1);
            }
            else
            {
                var TrongLuongPairedPlans = _context.PairedPlans.Where(a => a.PlansId == SystemId).Sum(a => a.Trongluong);
                var data = (from a in _context.Plans
                            where a.Macn == HttpContext.Session.GetString("UnitName") && a.SystemId == SystemId && a.TrangthaiGhep == true && a.Trangthai == 0
                            select new
                            {
                                a.SystemId,
                                a.SoPa,
                                a.Trongluong,
                                TLCanGhep = a.Trongluong - ((decimal)TrongLuongPairedPlans == 0 ? 0 : (decimal)TrongLuongPairedPlans),
                                a.Dvt
                            }).FirstOrDefault();
                return Json(data);
            }
        }
        [HttpPost]
        public IActionResult Add_PairedPlans(string id,string txtIdHD_MUA, string txtTrongLuongHD_MUA,string txtDvtHD_MUA,string txtTrongLuongGhepHD_MUA, string txtIdHD_BAN,string txtTrongLuongHD_BAN,string txtDvtHD_BAN,string txtTrongLuongGhepHD_BAN,bool ChbHoangThanhGhepHd_MUA,bool ChbHoangThanhGhepHd_BAN)
        {
            var checkHopDong = txtIdHD_MUA == null ? txtIdHD_BAN : txtIdHD_MUA;
            var hdmb = _context.Hdmbs.Where(a => a.Systemref == checkHopDong).FirstOrDefault();
            if (hdmb.MuaBan == "MUA")
            {

                double quatity;
                if (double.TryParse(txtTrongLuongHD_MUA,out quatity))
                {
                    if (quatity > QuantityMaxHD || quatity > double.Parse(txtTrongLuongGhepHD_MUA))
                    {
                        TempData["alertMessage"] = "Bạn nhập trọng lượng nhiều hơn trọng lượng trên hợp đồng hoặc nhiều hơn trọng lượng cần nhập cho phương án này";
                        return RedirectToAction("hdmb", "Hopdong");
                    }
                    if (quatity <= 0)
                    {
                        TempData["alertMessage"] = "Số lượng phải lớn hơn 0";
                        return RedirectToAction("hdmb", "Hopdong");
                    }
                }
                else
                    return RedirectToAction("hdmb", "Hopdong");
                if (_context.PairedPlans.Any(a => a.ContracId == txtIdHD_MUA))
                    return RedirectToAction("hdmb", "Hopdong");
                try
                {
                    PairedPlan pairedPlan = new PairedPlan();
                    pairedPlan.SystemId = AutoId.AutoIdFileStored("pairedplans");
                    pairedPlan.PlansId = id;
                    pairedPlan.ContracId = txtIdHD_MUA;
                    pairedPlan.Trongluong = quatity;
                    pairedPlan.Dvt = txtDvtHD_MUA;
                    pairedPlan.Macn = HttpContext.Session.GetString("UnitName");
                    hdmb.TrangthaiGhep = ChbHoangThanhGhepHd_MUA;
                    _context.Hdmbs.Update(hdmb);
                    _context.PairedPlans.Add(pairedPlan);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Ghép phương án thành công";
                    return RedirectToAction("hdmb", "Hopdong");
                }
                catch(Exception ex)
                {
                    TempData["alertMessage"] = ex;
                    return RedirectToAction("hdmb", "Hopdong");
                }
                
            }
            else
            {
                double quantity = 0;
                if (double.TryParse(txtTrongLuongHD_BAN,out quantity))
                {
                    if (quantity > double.Parse(txtTrongLuongHD_BAN))
                    {
                        TempData["alertMessage"] = "Bạn nhập trọng lượng ghép nhiều hơn trọng lượng trên hợp đồng cho phương án này";
                        return RedirectToAction("hdmb", "Hopdong");
                    }
                }
                else
                    return RedirectToAction("hdmb", "Hopdong");
                try
                {
                    PairedPlan pairedPlan = new PairedPlan();
                    pairedPlan.SystemId = AutoId.AutoIdFileStored("pairedplans");
                    pairedPlan.PlansId = id;
                    pairedPlan.ContracId = txtIdHD_BAN;
                    pairedPlan.Trongluong = quantity;
                    pairedPlan.Dvt = txtDvtHD_BAN;
                    pairedPlan.Macn = HttpContext.Session.GetString("UnitName");
                    hdmb.TrangthaiGhep = ChbHoangThanhGhepHd_BAN;
                    _context.Hdmbs.Update(hdmb);
                    _context.PairedPlans.Add(pairedPlan);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Ghép phương án thành công";
                    return RedirectToAction("hdmb", "Hopdong");
                }
                catch(Exception ex)
                {
                    TempData["alertMessage"] = ex;
                    return RedirectToAction("hdmb", "Hopdong");
                }
            }   
        }
        public IActionResult pakd()
        {
            return View("pakd");
        }
        public object GetPAKD(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Plans
                        where a.IsNew == true && a.Macn == HttpContext.Session.GetString("UnitName")
                        select new
                        {
                            SystemId = a.SystemId.Trim(),
                            SoPa = a.SoPa.Trim(),
                            LaiRong = a.LaiRong,
                            NgayPa = a.NgayPa,
                            Trangthai = a.Trangthai
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
    }
}
