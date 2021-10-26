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

namespace Intimex_project.Controllers
{
    public class HomeController : Controller
    {
        private SignalRChatContext _context = new SignalRChatContext();
        private IHostEnvironment _env;
        private string _dir;
        public HomeController(IHostEnvironment env)
        {
            _env = env;
            _dir = _env.ContentRootPath;
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
                var itemRemove = NotificationList.messages.Where(a => a.FromUser == sender && a.ToUser == receiver).ToList();
                var itemRemove1 = _context.Messages.Where(a => a.FromUser == sender && a.ToUser == receiver).FirstOrDefault();
                NotificationList.messages.Remove(itemRemove1);
                ViewBag.outMsg = (from a in _context.Messages where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender) orderby a.Id descending select new Message{
                    Id = a.Id,
                    FromUser = a.FromUser,
                    ToUser = a.ToUser,
                    Date = a.Date,
                    Message1 = EncryptString.Decrypt(a.Message1, "0933652637"),
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
            var query1 = (from a in _context.Messages
                              where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender)
                              orderby a.Id descending
                              select new Message
                              {
                                  Id = a.Id,
                                  FromUser = a.FromUser,
                                  ToUser = a.ToUser,
                                  Date = a.Date,
                                  Message1 = EncryptString.Decrypt(a.Message1, "0933652637"),
                              }).Skip(pageSize * pageIndex).Take(pageSize);
            var data = query1.OrderByDescending(a => a.Id).ToListAsync();
            return Json(await data);

        }
        [HttpPost]
        public async void Upload(IFormFile file)
        {
            string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
            }
        }
        public async Task<IActionResult> DownloadDocument(string id)
        {
            var filename = id;
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/FileUploads", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "APPLICATION/octet-stream", Path.GetFileName(path));
        }

        public JsonResult GetNotification() {
            var list = NotificationList.messages;
            return Json(list); 
        }

        public IActionResult GetPageFromNotification(int id) {
            var message = _context.Messages.Where(a => a.Id == id).FirstOrDefault();
            if (HttpContext.Session.GetString("userId") == null) {
                return RedirectToAction("index", "Account");
            } else {
                var fromUser = message.FromUser;
                ViewBag.messingTo = _context.AspNetUsers.Where(a => a.Id == fromUser).Select(a => a.NormalizedUserName).FirstOrDefault();
                var sender = message.FromUser;
                var receiver = message.ToUser;
                NotificationList.messages.RemoveAll(a => a.Id == id);
                ViewBag.outMsg = (from a in _context.Messages where (a.FromUser == sender && a.ToUser == receiver) || (a.FromUser == receiver && a.ToUser == sender) orderby a.Id descending select new Message {
                    Id = a.Id,
                    FromUser = a.FromUser,
                    ToUser = a.ToUser,
                    Date = a.Date,
                    Message1 = EncryptString.Decrypt(a.Message1, "0933652637"),
                }).Take(10).OrderBy(a => a.Id).ToList();
                ViewBag.sender = message.FromUser;
                ViewBag.receiver = message.ToUser;
                UserIdParameter.userId = HttpContext.Session.GetString("userId");
                UserIdParameter.userIdChat = message.ToUser;
                ViewBag.user = _context.AspNetUsers.Where(a => a.Id != HttpContext.Session.GetString("userId")).ToList();
                return View("PartialViewChat");
            }
        }
    }
}
