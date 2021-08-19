using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class NhapkhoController : Controller
    {
        private readonly tradingsystem_blContext _context = new tradingsystem_blContext(Parameter.connectionString);
        private const string DocumentId2 = "MyDocument2";
        public NhapkhoController()
        {
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
            var datetime = DateTime.Now.Date;
            var idxeptaitoday = _context.XepTais.Where(a => a.Ngaycan == datetime).Select(a => a.Xeptaiso).Count();
            if (idxeptaitoday == 0)
            {
                newXeptai.Xeptaiso = 1;
            }
            else
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
                        var autoincrement_can = _context.AutomaticValuesBranches.Where(a => a.Macn == HttpContext.Session.GetString("UnitName") && a.ObjectName == "CANBLI").FirstOrDefault();
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
            foreach (var item in canid)
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
