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
using Application.Parameter;

namespace Intimex_project.Controllers
{
    public class HomeController : Controller
    {
        private SignalRChatContext _context = new SignalRChatContext();

        public HomeController()
        {
        }
        public IActionResult Index()
        {
            var id = HttpContext.Session.GetString("userId");
            if (id != null)
            {
                ViewBag.CountUserOnline = (from a in _context.AspNetUsers where a.Online == true select a.NormalizedUserName).Count();
                ViewBag.countuser = (from a in _context.UserRights select a.UserId).Count();
                return View();
            }
            else
            {
                return RedirectToAction("index", "Account");
            }
        }

        public IActionResult chat()
        {
            ViewBag.user = _context.AspNetUsers.ToList();
            return View("chat");
        }
        public IActionResult PartialViewChat(string id)
        {
            ViewBag.sender = HttpContext.Session.GetString("userId");
            ViewBag.receiver = id;
            UserIdParameter.userId = HttpContext.Session.GetString("userId");
            UserIdParameter.userIdChat = id;
            ViewBag.user = _context.AspNetUsers.ToList();
            return View("PartialViewChat");
        }
    }
}
