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
using Data.Public_class;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Hosting;
using Application.Encrypt;
using Application.AccountMail;
using Microsoft.Extensions.Configuration;

namespace Intimex_project.Controllers
{
    public class HomeController : Controller
    {
        private SignalRChatContext _context = new SignalRChatContext();
        private IHostEnvironment _env;
        private IConfiguration _configuration;
        public HomeController(IHostEnvironment env, IConfiguration iconfig)
        {
            _env = env;
            _configuration = iconfig;
        }
        public IActionResult Index()
        {
            var id = HttpContext.Session.GetString("userId");
            ViewBag.userId = id;
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
            if (HttpContext.Session.GetString("userId") == null)
            {
                return RedirectToAction("index", "Account");
            }
            else
            {
                ViewBag.listUserOnline = ListUser.CurrentConnection.ToList();
                ViewBag.user = _context.AspNetUsers.Where(a => a.Id != HttpContext.Session.GetString("userId")).ToList();
                return View("chat");
            }  
        }          
        public IActionResult PartialViewChat(string id)
        {
            if (HttpContext.Session.GetString("userId") == null)
            {
                return RedirectToAction("index", "Account");
            }
            else
            {
                ViewBag.messingTo = _context.AspNetUsers.Where(a => a.Id == id).Select(a => a.NormalizedUserName).FirstOrDefault();
                var sender = HttpContext.Session.GetString("userId");
                var receiver = id;
                var notificationList = NotificationList.notifications;
                var SecurityStampSender = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.SecurityStamp).FirstOrDefault();
                var SecurityStampReceiver = _context.AspNetUsers.Where(a => a.Id == receiver).Select(a => a.SecurityStamp).FirstOrDefault();
                ViewBag.outMsg = (from a in _context.Messages where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender) orderby a.Id descending select new Message{
                    Id = a.Id,
                    FromUser = a.FromUser,
                    ToUser = a.ToUser,
                    Date = a.Date,
                    Message1 = EncryptString.Decrypt(a.Message1, (a.FromUser == sender && a.ToUser == receiver) ? SecurityStampSender : SecurityStampReceiver),
                }).Take(10).OrderBy(a => a.Id).ToList();
                ViewBag.sender = HttpContext.Session.GetString("userId");
                ViewBag.receiver = id;
                UserIdParameter.userId = HttpContext.Session.GetString("userId");
                UserIdParameter.userIdChat = id;
                ViewBag.user = _context.AspNetUsers.Where(a => a.Id != HttpContext.Session.GetString("userId")).ToList();
                return View("PartialViewChat");
            }
            
        }
        public async Task<JsonResult> GetDataMessage(int pageIndex, int pageSize, string id)
        {
            var sender = HttpContext.Session.GetString("userId");
            var receiver = id;
            var SecurityStampSender = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.SecurityStamp).FirstOrDefault();
            var SecurityStampReceiver = _context.AspNetUsers.Where(a => a.Id == receiver).Select(a => a.SecurityStamp).FirstOrDefault();
            var query1 = (from a in _context.Messages
                              where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender)
                              orderby a.Id descending
                              select new Message
                              {
                                  Id = a.Id,
                                  FromUser = a.FromUser,
                                  ToUser = a.ToUser,
                                  Date = a.Date,
                                  Message1 = EncryptString.Decrypt(a.Message1, (a.FromUser == sender && a.ToUser == receiver) ? SecurityStampSender : SecurityStampReceiver),
                              }).Skip(pageSize * pageIndex).Take(pageSize);
            var data = query1.OrderByDescending(a => a.Id).ToListAsync();
            return Json(await data);

        }
        [HttpPost]
        public void Upload(IFormFile file)
        {
            string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Chat\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                 file.CopyTo(fileStream);
                 fileStream.Flush();
            }
        }
        public async Task<IActionResult> DownloadDocument(string id)
        {
            var filename = id;
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/FileUploads/Chat", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "APPLICATION/octet-stream", Path.GetFileName(path));
        }

        public JsonResult GetNotification() {
            var list = NotificationList.notifications;
            return Json(list); 
        }

        public IActionResult ViewNotification(int id)
        {
            var message = _context.Messages.Where(a => a.Id == id).FirstOrDefault();
            NotificationList.notifications.RemoveAll(a => a.id == id);
            return RedirectToAction("PartialViewChat", "home",new { id = message.FromUser });
        }
    }
}
