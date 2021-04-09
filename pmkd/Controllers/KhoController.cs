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
            return View("dangkynhapkho");
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
            var autoincrement_can = _context.AutomaticValuesBranches.Where(a => a.Macn == "INXBL" && a.ObjectName == "CANBLI").FirstOrDefault();
            var autoincrement_kcs = _context.AutomaticValuesBranches.Where(a => a.Macn == "INXBL" && a.ObjectName == "KCSNNLBLI").FirstOrDefault();
            if (!TryValidateModel(xeptai))
                return BadRequest(GetFullErrorMessage(ModelState));
            var datetime = DateTime.Now;
            var makhach = xeptai.MaKhach;
            xeptai.KhachHang = (from a in _context.KhachHangs where a.MaKhach == makhach select a.TenKhach).FirstOrDefault();
            var mahang = xeptai.Mahang;
            xeptai.Tenhang = (_context.Hanghoas.Where(a => a.Mahang == mahang).Select(a => a.Tenhang)).FirstOrDefault();
            var uniname = HttpContext.Session.GetString("UnitName");
            xeptai.ApproveDate = datetime.Date;
            xeptai.ApproveTime = datetime.ToString("HH:mm");
            xeptai.UserApove = HttpContext.Session.GetString("userId");
            var PrefixOfDefaultValueForId_kcs = autoincrement_kcs.PrefixOfDefaultValueForId;
            var LengthOfDefaultValueForId_kcs = autoincrement_kcs.LengthOfDefaultValueForId;
            var LastValueOfColumnId_kcs = autoincrement_kcs.LastValueOfColumnId;
            var oldValue_kcs = LastValueOfColumnId_kcs.Substring(6, 5);
            var oldValueInt_kcs = Convert.ToInt32(oldValue_kcs);
            
            var PrefixOfDefaultValueForId = (from a in _context.AutomaticValuesBranches 
                                             where a.Macn == "INXBL" && a.ObjectName == "CANBLI" 
                                             select a.PrefixOfDefaultValueForId).FirstOrDefault();
            var LengthOfDefaultValueForId = (int)(from a in _context.AutomaticValuesBranches
                                             where a.Macn == "INXBL" && a.ObjectName == "CANBLI"
                                             select a.LengthOfDefaultValueForId).FirstOrDefault();
            var LastValueOfColumnId = (from a in _context.AutomaticValuesBranches
                                      where a.Macn == "INXBL" && a.ObjectName == "CANBLI"
                                      select a.LastValueOfColumnId).FirstOrDefault();
            var currentValue_kcs = oldValueInt_kcs + 1;
            var nextValue_kcs = oldValueInt_kcs + 2;
            var chuoi_kcs = "00000000" + Convert.ToString(currentValue_kcs);
            var chuoinext_kcs = "00000000" + Convert.ToString(nextValue_kcs);
            var parameterOut_kcs = PrefixOfDefaultValueForId + chuoi_kcs.Substring(chuoi_kcs.Length + PrefixOfDefaultValueForId.Length + 1 - LengthOfDefaultValueForId, 6);
            var next_kcs = PrefixOfDefaultValueForId + chuoinext_kcs.Substring(chuoinext_kcs.Length + PrefixOfDefaultValueForId.Length + 1 - LengthOfDefaultValueForId, 6);
            xeptai.Kcs = parameterOut_kcs;
            xeptai.Canfinish = true;
            autoincrement_kcs.LastValueOfColumnId = parameterOut_kcs;
            autoincrement_kcs.NextValueOfColumnId = next_kcs;
            var oldValue = LastValueOfColumnId.Substring(6, 5);
            var oldValueInt = Convert.ToInt32(oldValue);
            var currentValue = oldValueInt + 1;
            var nextValue = oldValueInt + 2;
            var chuoi = "00000000" + Convert.ToString(currentValue);
            var chuoinext = "00000000" + Convert.ToString(nextValue);
            var parameterOut = PrefixOfDefaultValueForId + chuoi.Substring(chuoi.Length + PrefixOfDefaultValueForId.Length + 1 - LengthOfDefaultValueForId, 6);
            var next = PrefixOfDefaultValueForId + chuoinext.Substring(chuoinext.Length + PrefixOfDefaultValueForId.Length + 1 - LengthOfDefaultValueForId, 6);
            xeptai.CanId = parameterOut;
            autoincrement_can.LastValueOfColumnId = parameterOut;
            autoincrement_can.NextValueOfColumnId = next;
            _context.AutomaticValuesBranches.Update(autoincrement_can);
            _context.AutomaticValuesBranches.Update(autoincrement_kcs);
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
    }
}
