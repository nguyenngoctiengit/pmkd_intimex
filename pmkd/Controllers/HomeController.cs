using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using pmkd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using DevExpress.AspNetCore.Spreadsheet;
using System.Configuration;

namespace pmkd.Controllers
{

    public class HomeController : Controller
    {
        private readonly tradingsystem_blContext _context = new tradingsystem_blContext("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=SignalRChat;Trusted_Connection=True;Integrated Security=SSPI;MultipleActiveResultSets=true");

        public HomeController(tradingsystem_blContext context)
        {
        }
        public IActionResult Index()
        {
            var id = HttpContext.Session.GetString("userId");
            if (id != null)
            {
                var userName = HttpContext.Session.GetString("userId");
                var item = _context.UserRights.Where(a => a.UserName1 == userName).FirstOrDefault();
                item.Online = 1;
                _context.UserRights.Update(item).Property(a => a.UserId).IsModified = false;
                _context.SaveChanges();
                ViewBag.CountUserOnline = (from a in _context.UserRights where a.Online == 1 select a.UserId).Count();
                ViewBag.ListUserOnline = (from a in _context.UserRights where a.Online == 1 select new UserRight { UserName1 = a.UserName1 }).ToList();
                ViewBag.countuser = (from a in _context.UserRights select a.UserId).Count();
                return View();
            }
            else
            {

                return RedirectToAction("index", "Account");
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult DevExtremeLayout()
        {
            return View("_DevExtremeLayout");
        }
    }
}
