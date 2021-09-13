using Application.Parameter;
using Data.Models.SignalR;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class KcsController : Controller
    {
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        private const string DocumentId2 = "MyDocument2";
        public KcsController()
        {
        }
        public void listUser()
        {
            using (SignalRChatContext _context = new SignalRChatContext())
            {
                ViewBag.ListUser = (from a in _context.AspNetUsers select new Data.Models.SignalR.AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online, Id = a.Id }).OrderByDescending(a => a.Online).ToList();
            }
        }
        public IActionResult kcs()
        {
            listUser();
            var yesterday = DateTime.Today.AddDays(-1);
            var today = DateTime.Now;
            var aa = (from a in _context.Cans where a.DateIn > yesterday select a).ToList();
            return View("kcs");
        }
        [HttpGet]
        public object getKcs(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.Kcs, loadOptions);
        }
        [Route("kcs/kcs/themkcs")]
        public IActionResult themkcs()
        {
            listUser();
            ViewBag.name = HttpContext.Session.GetString("FullName1");
            ViewBag.xeptai = _context.XepTais.ToList();
            ViewBag.can = _context.Cans.ToList();
            return View("themkcs");
        }
        [HttpPost]
        public IActionResult themkcs1(Kc kc)
        {
            if (_context.Kcs.Where(a => a.XeptaiId == kc.XeptaiId).FirstOrDefault() != null)
            {
                TempData["alertMessage"] = "Xe đã được lập KCS, vui lòng kiểm tra lại";
                return RedirectToAction("themkcs");
            }
            var canid = _context.XepTais.Where(a => a.Id == kc.XeptaiId).Select(a => a.CanId).FirstOrDefault();
            if (_context.Cans.Where(a => a.SystemId == canid).Select(a => a.TlIn).FirstOrDefault() == 0 ||
                _context.Cans.Where(a => a.SystemId == canid).Select(a => a.TlOut).FirstOrDefault() == 0 ||
                _context.Cans.Where(a => a.SystemId == canid).Select(a => a.TlNet).FirstOrDefault() == 0)
            {
                TempData["alertMessage"] = "Xe chưa hoàn tất cân hàng, làm ơn hoàn tất cân hàng trước khi lập kcs";
                return RedirectToAction("themkcs");
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Kc kc1 = new Kc();
                    XepTai xepTai = _context.XepTais.Where(a => a.Id == kc.XeptaiId).FirstOrDefault();
                    var autoincrement_kcs = _context.AutomaticValuesBranches.Where(a => a.Macn == HttpContext.Session.GetString("UnitName") && a.ObjectName == "KCSNNLBLI").FirstOrDefault();
                    var PrefixOfDefaultValueForId_kcs = autoincrement_kcs.PrefixOfDefaultValueForId;
                    var LengthOfDefaultValueForId_kcs = (int)autoincrement_kcs.LengthOfDefaultValueForId;
                    var LastValueOfColumnId_kcs = autoincrement_kcs.LastValueOfColumnId;
                    var oldValue_kcs = LastValueOfColumnId_kcs.Substring(6, 6);
                    var oldValueInt_kcs = Convert.ToInt32(oldValue_kcs);
                    var currentValue_kcs = oldValueInt_kcs + 1;
                    var nextValue_kcs = oldValueInt_kcs + 2;
                    var chuoi_kcs = "00000000" + Convert.ToString(currentValue_kcs);
                    var chuoinext_kcs = "00000000" + Convert.ToString(nextValue_kcs);
                    var parameterOut_kcs = PrefixOfDefaultValueForId_kcs + chuoi_kcs.Substring(chuoi_kcs.Length + PrefixOfDefaultValueForId_kcs.Length - LengthOfDefaultValueForId_kcs, 7);
                    var next_kcs = PrefixOfDefaultValueForId_kcs + chuoinext_kcs.Substring(chuoinext_kcs.Length + PrefixOfDefaultValueForId_kcs.Length - LengthOfDefaultValueForId_kcs, 7);
                    xepTai.Kcs = parameterOut_kcs;
                    autoincrement_kcs.LastValueOfColumnId = parameterOut_kcs;
                    autoincrement_kcs.NextValueOfColumnId = next_kcs;
                    kc1.SoPhieu = parameterOut_kcs;
                    kc1.NguoiGiao = kc.KhachHang;
                    var xevc = (from a in _context.XepTais where a.Id == kc.XeptaiId select a.SoXe).FirstOrDefault();
                    kc1.XeVc = xevc;
                    kc1.KhachHang = kc.KhachHang; kc1.DoAm = kc.DoAm; kc1.TapChat = kc.TapChat; kc1.DenVo = kc.DenVo; kc1.HatMoc = kc.HatMoc;
                    kc1.HatNau = kc.HatNau; kc1.HatCxk = kc.HatCxk; kc1.TrangXop = kc.TrangXop; kc1.HatChay = kc.HatChay;
                    kc1.Sang8 = kc.Sang8; kc1.Sang12 = kc.Sang12; kc1.Sang13 = kc.Sang13; kc1.Sang14 = kc.Sang14; kc1.Sang15 = kc.Sang15;
                    kc1.Sang16 = kc.Sang16; kc1.Sang17 = kc.Sang17; kc1.Sang18 = kc.Sang18; kc1.Sang19 = kc.Sang19; kc1.Sang20 = kc.Sang20;
                    kc1.Ghichu = kc.Ghichu;
                    kc1.Manhom = kc.Manhom;
                    kc1.NgayNhap = DateTime.Now;
                    kc1.NguoiKiem = kc.NguoiKiem;
                    kc1.LoaiKcs = 1;
                    kc1.SoLuong = kc.SoLuong;
                    kc1.PhuTrach = kc.PhuTrach;
                    kc1.NguonHang = kc.NguonHang;
                    kc1.Dvt = "kgs";
                    var canid1 = (from a in _context.XepTais where a.Id == kc.XeptaiId select a.CanId).FirstOrDefault();
                    var khoid = (from a in _context.XepTais where a.Id == kc.XeptaiId select a.KhoId).FirstOrDefault();
                    kc1.CanId = canid1;
                    kc1.KhoId = khoid;
                    kc1.TrongLuongNw = kc.TrongLuongNw;
                    kc1.NguoiLayMau = kc.NguoiLayMau;
                    kc1.XeptaiId = kc.XeptaiId;
                    kc1.Macn = HttpContext.Session.GetString("UnitName");
                    kc1.NguoiTao = HttpContext.Session.GetString("userId");
                    kc1.NgayPhieu = kc1.NgayNhap;
                    kc1.TenKhach = kc.TenKhach;
                    kc1.LoaiBao = kc.LoaiBao;
                    kc1.TrongLuong = kc.TrongLuong;
                    kc1.Mahang = kc.Mahang;
                    kc1.TenHang = kc.TenHang;
                    _context.AutomaticValuesBranches.Update(autoincrement_kcs);
                    _context.XepTais.Update(xepTai);
                    _context.Kcs.Add(kc1);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["alertMessage"] = ex;
                    return RedirectToAction("themkcs");
                }
            }
            _context.SaveChanges();
            TempData["alertMessage"] = "thêm KCS thành công";
            return RedirectToAction("kcs");

        }
        [HttpPut]
        public async Task<IActionResult> updateKcs(string key, string values)
        {

            var xeptai = _context.Kcs.First(o => o.SoPhieu == key);
            JsonConvert.PopulateObject(values, xeptai);
            _context.Kcs.Update(xeptai);
            await _context.SaveChangesAsync();
            return Ok(xeptai);
        }
    }
}
