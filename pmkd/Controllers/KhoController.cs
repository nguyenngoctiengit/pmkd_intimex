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
            xeptai.ApproveDate = datetime.Date;
            xeptai.ApproveTime = datetime.ToString("HH:mm");
            xeptai.UserApove = HttpContext.Session.GetString("userId");
            _context.SaveChanges();

            return Ok(xeptai);
        }

        [HttpDelete]
        public void DeleteXepTai(int key)
        {
            var order = _context.XepTais.First(o => o.Id == key);
            _context.XepTais.Remove(order);
            _context.SaveChanges();
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
