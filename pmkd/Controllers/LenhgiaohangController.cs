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
    public class LenhgiaohangController : Controller
    {
        public tradingsystem_blContext _context;
        private const string DocumentId2 = "MyDocument2";
        public LenhgiaohangController(tradingsystem_blContext context)
        {
            _context = context;
        }
        public IActionResult lenhgiaohang()
        {
            return View("lenhgiaohang");
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
