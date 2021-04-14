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
using config = System.Configuration.ConfigurationManager;
using System.IO.Ports;

namespace pmkd.Controllers
{
    public class KhoController : Controller
    {
        public SerialPort comport = new SerialPort();
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
        public IActionResult UpdateXeptai(int key, string values)
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
            if (xeptai.CanId == "")
            {
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
                autoincrement_can.LastValueOfColumnId = parameterOut;
                autoincrement_can.NextValueOfColumnId = next;
                _context.AutomaticValuesBranches.Update(autoincrement_can);
            }
            if (xeptai.Kcs == "")
            {
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
                xeptai.Kcs = parameterOut_kcs;
                autoincrement_kcs.LastValueOfColumnId = parameterOut_kcs;
                autoincrement_kcs.NextValueOfColumnId = next_kcs;
                _context.AutomaticValuesBranches.Update(autoincrement_kcs);
            }
            if (!TryValidateModel(xeptai))
                return BadRequest(GetFullErrorMessage(ModelState));
            var makhach = xeptai.MaKhach;
            xeptai.KhachHang = (from a in _context.KhachHangs where a.MaKhach == makhach select a.TenKhach).FirstOrDefault();
            var mahang = xeptai.Mahang;
            xeptai.Tenhang = (_context.Hanghoas.Where(a => a.Mahang == mahang).Select(a => a.Tenhang)).FirstOrDefault();
            xeptai.Canfinish = true;
            _context.SaveChanges();
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
        public IActionResult cantrongluong()
        {
            return View("can/can");
        }
        //---------------------------Lệnh giao hàng--------------------------
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

            if (!TryValidateModel(newLenhgiaohang))
                return BadRequest(GetFullErrorMessage(ModelState));
            
            
            _context.SaveChanges();

            return Ok(newLenhgiaohang);
        }
    }
}
