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
        private readonly tradingsystem_blContext _context = new tradingsystem_blContext("Server=.\\SQLEXPRESS;Database=tradingsystem;Trusted_Connection=True;Integrated Security=SSPI;MultipleActiveResultSets=true");

        public HomeController(tradingsystem_blContext context)
        {
        }
        public IActionResult Index()
        {

            using (SignalRChatContext _context = new SignalRChatContext())
            {
                var id = HttpContext.Session.GetString("userId");
                if (id != null)
                {
                    ViewBag.CountUserOnline = (from a in _context.AspNetUsers where a.Online == true select a.NormalizedUserName).Count();
                    ViewBag.ListUser = (from a in _context.AspNetUsers select new AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online }).OrderByDescending(a => a.Online).ToList();
                    ViewBag.countuser = (from a in _context.UserRights select a.UserId).Count();
                    return View();
                }
                else
                {

                    return RedirectToAction("index", "Account");
                }
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
