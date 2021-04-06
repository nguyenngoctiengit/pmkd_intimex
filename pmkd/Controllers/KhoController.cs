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
            var datetime = DateTime.Now;
            newXeptai.ApproveDate = datetime.Date;
            newXeptai.ApproveTime = datetime.ToString("HH:mm");
            newXeptai.UserApove = HttpContext.Session.GetString("userId");
            _context.XepTais.Add(newXeptai);
            _context.SaveChanges();

            return Ok(newXeptai);
        }
        [HttpPut]
        public IActionResult UpdateXeptai(int key, string values)
        {
            var xeptai = _context.XepTais.First(o => o.Id == key);
            JsonConvert.PopulateObject(values, xeptai);

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
