using Data.Models.Trading_system;
using Intimex_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.SignalR;
using Microsoft.AspNetCore.Http;

namespace Intimex_project.Controllers
{
    public class HomeController : Controller
    {
        private SignalRChatContext _context = new SignalRChatContext();

        public HomeController()
        {
        }
        public void listUser()
        {
            ViewBag.ListUser = (from a in _context.AspNetUsers select new Data.Models.SignalR.AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online, Id = a.Id }).OrderByDescending(a => a.Online).ToList();
        }
        public IActionResult Index()
        {
            var id = HttpContext.Session.GetString("userId");
            if (id != null)
            {
                ViewBag.CountUserOnline = (from a in _context.AspNetUsers where a.Online == true select a.NormalizedUserName).Count();
                listUser();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
