﻿using Data.Models.Trading_system;
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
using Data.Public_class;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

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
            ViewBag.listUserOnline = ListUser.CurrentConnection.ToList();
            ViewBag.user = _context.AspNetUsers.Where(a => a.Id != HttpContext.Session.GetString("userId")).ToList();
            return View("chat");
        }
        public IActionResult PartialViewChat(string id)
        {
            ViewBag.listUserOnline = ListUser.CurrentConnection.ToList();
            ViewBag.messingTo = _context.AspNetUsers.Where(a => a.Id == id).Select(a => a.NormalizedUserName).FirstOrDefault();
            var sender = HttpContext.Session.GetString("userId");
            var receiver = id;
            var query = (from a in _context.Messages where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender) orderby a.Id descending select a).Take(10);
            ViewBag.outMsg = query.OrderBy(a => a.Id).ToList();
            ViewBag.sender = HttpContext.Session.GetString("userId");
            ViewBag.receiver = id;
            UserIdParameter.userId = HttpContext.Session.GetString("userId");
            UserIdParameter.userIdChat = id;
            ViewBag.user = _context.AspNetUsers.Where(a => a.Id != HttpContext.Session.GetString("userId")).ToList();
            return View("PartialViewChat");
        }
        public async Task<JsonResult> GetDataMessage(int pageIndex, int pageSize, string id)
        {
            var sender = HttpContext.Session.GetString("userId");
            var receiver = id;
            var query = (from a in _context.Messages where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender) orderby a.Id descending select a).Skip(pageSize * pageIndex).Take(pageSize);
            var data = query.OrderByDescending(a => a.Id).ToListAsync();
            return Json(await data);

        }
        [HttpPost]
        public IActionResult Upload(IFormFile file,[FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\FileUploads\\{file.FileName}";
            Message message = new Message();
            message.FromUser = UserIdParameter.userId;
            message.ToUser = UserIdParameter.userIdChat;
            message.Message1 = file.FileName;
            message.Date = DateTime.Now;
            _context.Messages.Add(message);
            _context.SaveChanges();
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return RedirectToAction("PartialViewChat",new { id = UserIdParameter.userIdChat });
        }
    }
}
