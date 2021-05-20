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
using System.IO;
using System.IO.Ports;

namespace pmkd.Controllers
{
    public class KhoController : Controller
    {
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        
        public KhoController(tradingsystem_blContext context)
        {
            _context = context;
        }
        public IActionResult dangkynhapkho()
        {
            return View("dangkynhapkho/dangkynhapkho");
        }
        [HttpGet]
        public object GetXepTai(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.XepTais, loadOptions);
        }
        [HttpPost]
        public IActionResult InsertXepTai(string values)
        {
            
            var newXeptai = new XepTai();
            JsonConvert.PopulateObject(values, newXeptai);

            if (!TryValidateModel(newXeptai))
                return BadRequest(GetFullErrorMessage(ModelState));
            if (newXeptai.GhiChu == null)
            {
                newXeptai.GhiChu = "";
            }
            var datetime = DateTime.Now.Date;
            var idxeptaitoday = _context.XepTais.Where(a => a.Ngaycan == datetime).Select(a => a.Xeptaiso).Count();
            if (idxeptaitoday == 0)
            {
                newXeptai.Xeptaiso = 1;
            }else
            {
                newXeptai.Xeptaiso = idxeptaitoday + 1;
            }
            var makhach = newXeptai.MaKhach;
            newXeptai.KhachHang = (from a in _context.KhachHangs where a.MaKhach == makhach select a.TenKhach).FirstOrDefault();
            var mahang = newXeptai.Mahang;
            newXeptai.Tenhang = (_context.Hanghoas.Where(a => a.Mahang == mahang).Select(a => a.Tenhang)).FirstOrDefault();
            var uniname = HttpContext.Session.GetString("UnitName");
            newXeptai.Macn = uniname;
            var makho = newXeptai.KhoId.ToString();
            newXeptai.KhoName = (_context.Stocks.Where(a => a.StockCode == makho).Select(a => a.StockName)).FirstOrDefault();
            newXeptai.NgayHd = (_context.Hdmbs.Where(a => a.Sohd == newXeptai.HopDong).Select(a => a.Ngayky)).FirstOrDefault();
            newXeptai.Status = 1;
            newXeptai.Aprove = 2;
            newXeptai.IsHoanThanh = false;
            _context.XepTais.Add(newXeptai);
            _context.SaveChanges();

            return Ok(newXeptai);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateXeptai(int key, string values)
        {            
            var xeptai = _context.XepTais.First(o => o.Id == key);
            JsonConvert.PopulateObject(values, xeptai);
            if (xeptai.ApproveTime == null)
            {
                var datetime = DateTime.Now;
                xeptai.ApproveTime = datetime.ToString("HH:mm");
                xeptai.ApproveDate = datetime.Date;
                var uniname = HttpContext.Session.GetString("UnitName");
                xeptai.UserApove = HttpContext.Session.GetString("userId");
            }
            var makhach = xeptai.MaKhach;
            xeptai.KhachHang = (from a in _context.KhachHangs where a.MaKhach == makhach select a.TenKhach).FirstOrDefault();
            var mahang = xeptai.Mahang;
            xeptai.Tenhang = (_context.Hanghoas.Where(a => a.Mahang == mahang).Select(a => a.Tenhang)).FirstOrDefault();
            xeptai.Canfinish = true;
            if (xeptai.CanId == "")
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        Can can = new Can();
                        var autoincrement_can = _context.AutomaticValuesBranches.Where(a => a.Macn == "INXBL" && a.ObjectName == "CANBLI").FirstOrDefault();
                        var PrefixOfDefaultValueForId = autoincrement_can.PrefixOfDefaultValueForId;
                        var LengthOfDefaultValueForId = (int)autoincrement_can.LengthOfDefaultValueForId;
                        var LastValueOfColumnId = autoincrement_can.LastValueOfColumnId;
                        var oldValue = LastValueOfColumnId.Substring(6, 6);
                        var oldValueInt = Convert.ToInt32(oldValue);
                        var currentValue = oldValueInt + 1;
                        var nextValue = oldValueInt + 2;
                        var chuoi = "00000000" + Convert.ToString(currentValue);
                        var chuoinext = "00000000" + Convert.ToString(nextValue);
                        var parameterOut = PrefixOfDefaultValueForId + chuoi.Substring(chuoi.Length + PrefixOfDefaultValueForId.Length - LengthOfDefaultValueForId, 7);
                        var next = PrefixOfDefaultValueForId + chuoinext.Substring(chuoinext.Length + PrefixOfDefaultValueForId.Length - LengthOfDefaultValueForId, 7);
                        xeptai.CanId = parameterOut;
                        xeptai.Aprove = 1;
                        autoincrement_can.LastValueOfColumnId = parameterOut;
                        autoincrement_can.NextValueOfColumnId = next;
                        _context.AutomaticValuesBranches.Update(autoincrement_can);
                        can.SystemId = parameterOut;
                        can.TruckNo = xeptai.SoXe;
                        can.IdXepTai = xeptai.Id;
                        can.SoBao = xeptai.SoBao;
                        var tenbao = (from a in _context.BagTypes where a.BagTypeId == xeptai.BagTypeId select a.Name).FirstOrDefault();
                        var qualitybao = (from a in _context.BagTypes where a.BagTypeId == xeptai.BagTypeId select a.Quantity).FirstOrDefault();
                        can.LoaiBao = xeptai.BagTypeId;
                        can.HinhThucCan = 0;
                        can.TlCont = 0;
                        can.TlCont1 = 0;
                        can.TlIn = 0;
                        can.ContNo = "";
                        can.ContNo1 = "";
                        can.SealNo = "";
                        can.SealNo1 = "";
                        can.TypeCont = true;
                        can.BagName = tenbao;
                        can.TlBao = xeptai.TlBaobi;
                        can.Quanlitybag = qualitybao;
                        can.Aprove = xeptai.Aprove;
                        can.Status = xeptai.Status;
                        can.Macn = HttpContext.Session.GetString("UnitName");
                        can.DateIn = xeptai.ApproveDate;
                        can.TimeIn = xeptai.ApproveTime;
                        can.CustCode = xeptai.MaKhach;
                        can.CustName = xeptai.KhachHang;
                        can.ProdCode = xeptai.Mahang;
                        can.ProdName = xeptai.Tenhang;
                        can.Xeptai1 = xeptai.Xeptaiso;
                        can.Sohd = xeptai.HopDong;
                        can.CachCan = 1;
                        can.KhoId = xeptai.KhoId;
                        var idhopdong = (from a in _context.Hdmbs where a.Sohd == xeptai.HopDong select a.Systemref).FirstOrDefault();
                        can.Idhopdong = idhopdong;
                        _context.Cans.Add(can);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return BadRequest("Error occurred" + ex);
                    }
                }  
            }
            if (!TryValidateModel(xeptai))
                return BadRequest(GetFullErrorMessage(ModelState));

            
            await _context.SaveChangesAsync();
            return Ok(xeptai);
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteXepTai(int key)
        {
            var item_delete = await _context.XepTais.FirstOrDefaultAsync(a => a.Id == key);
            var canid = _context.Cans.ToList();
            foreach(var item in canid)
            {
                if (item.SystemId == item_delete.CanId)
                {
                    return BadRequest("xe đã cân, không xóa đc");
                }
            }
            _context.XepTais.Remove(item_delete);
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
        ////------------------------Cân-------------------
        #region can
        public IActionResult cantrongluong()
        {
            ViewBag.nhanvien = (from k in _context.Cans
                                select k.NhanVien).Distinct().ToList();
            ViewBag.baove = (from k in _context.Cans
                             select k.BaoVe ).Distinct().ToList();
            ViewBag.thukho = (from k in _context.Cans
                              select k.ThuKho ).Distinct().ToList();
            ViewBag.nguoilap = (from k in _context.Cans
                                select k.NguoiLap).Distinct().ToList();
            ViewBag.lanhdao = (from k in _context.Cans
                               select k.LanhDao).Distinct().ToList();
            ViewBag.stock = _context.Stocks.ToList();
            ViewBag.listcan = _context.Cans.ToList();
            return View("can/can");
        }
        public object GetCan(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.Cans.OrderBy(a => a.Xeptai1), loadOptions);
        }
        [HttpPost][Route("kho/kho/updatetlin/{id?}")]
        public IActionResult updatetlin(Can can,string id)
        {
            var datetime = DateTime.Now;
            var item_return = _context.Cans.Where(a => a.SystemId == id).FirstOrDefault();
            if (can.TlIn != null)
            {
                if (item_return.TlIn == 0 || item_return.TlIn == null)
                {
                    item_return.TlIn = can.TlIn;
                    item_return.TimeIn = datetime.ToString("HH:mm");
                    item_return.DateIn = datetime.Date;
                }
                else if (item_return.TlIn != 0 || item_return.TlIn != null)
                {
                    item_return.TlOut = can.TlIn;
                    item_return.TimeOut = datetime.ToString("HH:mm");
                    item_return.DateIn = datetime.Date;

                }
                if ((item_return.TlIn != 0 || item_return.TlIn != null) && (item_return.TlOut != 0 || item_return != null))
                {
                    item_return.TlNet = Math.Abs(Convert.ToDecimal(item_return.TlIn - item_return.TlOut - item_return.TlBao));
                }
            }
            item_return.LaiXe = can.LaiXe;
            item_return.NguoiLap = can.NguoiLap;
            item_return.NhanVien = can.NhanVien;
            item_return.ThuKho = can.ThuKho;
            item_return.BaoVe = can.BaoVe;
            item_return.LanhDao = can.LanhDao;
            _context.Cans.Update(item_return);
            _context.SaveChanges();
            return RedirectToAction("cantrongluong");
        }
        #endregion
        //---------------------------Lệnh giao hàng--------------------------
        #region lệnh giao hàng
        public IActionResult lenhgiaohang()
        {
            return View("lenhgiaohang/lenhgiaohang");
        }
        [HttpGet]
        public object GetLenhGiaoHang(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.LenhGiaoHangs, loadOptions);
        }
        [HttpPost]
        public IActionResult InsertLenhGiaoHang(string values)
        {
            var newLenhgiaohang = new LenhGiaoHang();
            JsonConvert.PopulateObject(values, newLenhgiaohang);
            var list_lenhgiaohang = _context.LenhGiaoHangs.ToList();
            foreach (var item in list_lenhgiaohang)
            {
                if (newLenhgiaohang.SoLenh == item.SoLenh)
                {
                    return BadRequest("Số lệnh bị trùng");
                }
            }
            var khoxuatid = newLenhgiaohang.KhoXuatId.ToString();
            newLenhgiaohang.TenKhoXuat = (from a in _context.Stocks where a.StockCode == khoxuatid select a.StockName).FirstOrDefault();
            newLenhgiaohang.TenHang = (from a in _context.Hanghoas where a.Mahang == newLenhgiaohang.MaHang select a.Tenhang).FirstOrDefault();
            newLenhgiaohang.HdmbId = (from a in _context.Hdmbs where a.Sohd == newLenhgiaohang.Hdmb select a.Systemref).FirstOrDefault();
            newLenhgiaohang.TenKhach = (from a in _context.KhachHangs where a.MaKhach == newLenhgiaohang.MaKhach select a.TenKhach).FirstOrDefault();
            newLenhgiaohang.CreateBy = HttpContext.Session.GetString("userId");
            var datetime = DateTime.Now;
            newLenhgiaohang.CreateDate = datetime.Date;
            if (!TryValidateModel(newLenhgiaohang))
                return BadRequest(GetFullErrorMessage(ModelState));
            _context.LenhGiaoHangs.Add(newLenhgiaohang);
            _context.SaveChanges();
            return Ok(newLenhgiaohang);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteLenhGiaoHang(int key)
        {
            var item_delete = await _context.LenhGiaoHangs.FirstOrDefaultAsync(a => a.IdLenhGiaoHang == key);
            _context.LenhGiaoHangs.Remove(item_delete);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateLenhGiaoHang(int key, string values)
        {
            var lenhgiaohang = _context.LenhGiaoHangs.First(o => o.IdLenhGiaoHang == key);
            JsonConvert.PopulateObject(values, lenhgiaohang);
            var list_lenhgiaohang = _context.LenhGiaoHangs.ToList();
            var khoxuatid = lenhgiaohang.KhoXuatId.ToString();
            lenhgiaohang.TenKhoXuat = (from a in _context.Stocks where a.StockCode == khoxuatid select a.StockName).FirstOrDefault();
            lenhgiaohang.TenHang = (from a in _context.Hanghoas where a.Mahang == lenhgiaohang.MaHang select a.Tenhang).FirstOrDefault();
            lenhgiaohang.HdmbId = (from a in _context.Hdmbs where a.Sohd == lenhgiaohang.Hdmb select a.Systemref).FirstOrDefault();
            lenhgiaohang.TenKhach = (from a in _context.KhachHangs where a.MaKhach == lenhgiaohang.MaKhach select a.TenKhach).FirstOrDefault();
            lenhgiaohang.CreateBy = HttpContext.Session.GetString("userId");
            if (!TryValidateModel(lenhgiaohang))
                return BadRequest(GetFullErrorMessage(ModelState));
            _context.SaveChanges();
            return Ok(lenhgiaohang);
        }
        #endregion
        //---------------------------Kiểm tra chất lượng--------------------
        public IActionResult kcs()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var today = DateTime.Now;
            var aa = (from a in _context.Cans where a.DateIn > yesterday select a).ToList();
            return View("kcs/kcs");
        }
        [HttpGet]
        public object getKcs(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.Kcs, loadOptions);
        }
        [Route("kho/kho/themkcs")]
        public IActionResult themkcs()
        {
            ViewBag.name = HttpContext.Session.GetString("FullName1");
            ViewBag.xeptai = _context.XepTais.ToList();
            ViewBag.can = _context.Cans.ToList();
            return View("kcs/themkcs");
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
                    var autoincrement_kcs = _context.AutomaticValuesBranches.Where(a => a.Macn == "INXBL" && a.ObjectName == "KCSNNLBLI").FirstOrDefault();
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
                    kc1.KhachHang = kc.KhachHang;kc1.DoAm = kc.DoAm;kc1.TapChat = kc.TapChat;kc1.DenVo = kc.DenVo;kc1.HatMoc = kc.HatMoc;
                    kc1.HatNau = kc.HatNau;kc1.HatCxk = kc.HatCxk;kc1.TrangXop = kc.TrangXop;kc1.HatChay = kc.HatChay;
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
