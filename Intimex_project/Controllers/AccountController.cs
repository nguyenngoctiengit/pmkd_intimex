using Application.AccountMail;
using Application.AppServices;
using Application.Parameter;
using Data.Models.SignalR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Public_class;

namespace Intimex_project.Controllers
{
    public class AccountController : Controller
    {
        private IConfiguration configuration;
        private readonly SignalRChatContext _context = new SignalRChatContext();
        public AccountController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        [Route("admin")]
        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(AspNetUser aspNetUser)
        {
            if (ModelState.IsValid)
            {
                string userId;
                if (new AppService().login(aspNetUser,out userId) == true)
                {
                    var user = _context.AspNetUsers.FirstOrDefault(a => a.UserName == aspNetUser.UserName);
                    var userBranch = _context.UserBranches.Where(a => a.UserName == user.UserName).Count();
                    if (userBranch > 1)
                    {
                        ViewBag.userId = user.Id;
                        ViewBag.userBranch = _context.UserBranches.Where(a => a.UserName == user.UserName).Select(a => new { BranchId = a.BranchId }).ToList();
                        return View("chooseBranch");
                    }
                    else
                    {
                        ListUser.CurrentConnection.Add(user.Id);
                        var userdetails = _context.AspNetUsers.SingleOrDefault(m => m.UserName == user.UserName && m.Status == true);
                        HttpContext.Session.SetString("userId", user.Id);
                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("fullName", user.NormalizedUserName);
                        HttpContext.Session.SetString("UnitName", user.UnitName);
                        return RedirectToAction("Index", "Home");
                    }
                }
                return View("Index");
            }
            else
            {
                ViewBag.Message = "Vui lòng điền tài khoản hoặc mật khẩu";
                return View("index");
            }
        }
        public IActionResult loginwithUserBranch(AspNetUser aspNetUser)
        {
            var user = _context.AspNetUsers.SingleOrDefault(m => m.Id == aspNetUser.Id && m.Status == true);
            var userBranch = aspNetUser.UnitName;
            user.Online = true;
            _context.AspNetUsers.Update(user).Property(a => a.Id).IsModified = false;
            _context.SaveChanges();
            ListUser.CurrentConnection.Add(user.Id);
            HttpContext.Session.SetString("userId", user.Id);
            HttpContext.Session.SetString("UserName", user.UserName);
            HttpContext.Session.SetString("fullName", user.NormalizedUserName);
            if (userBranch == "INXBL")
            {
                HttpContext.Session.SetString("UnitName", "INXBL");
                ConnectionParameter.connectionString = "Server=.\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;MultipleActiveResultSets=true";
                return RedirectToAction("Index", "Home");
            }
            else if (userBranch == "INX")
            {
                HttpContext.Session.SetString("UnitName", "INX");
                ConnectionParameter.connectionString = "Server=.\\SQLEXPRESS;Database=tradingsystem;Trusted_Connection=True;MultipleActiveResultSets=true";
                return RedirectToAction("Index", "Home");
            }
            ConnectionParameter.connectionString = "Server=.\\SQLEXPRESS;Database=tradingsystem;Trusted_Connection=True;MultipleActiveResultSets=true";
            return RedirectToAction("Index", "Home");

        }

        // registration Page load
        public IActionResult Logout()
        {
            var userName = HttpContext.Session.GetString("userId");
            var item = _context.AspNetUsers.Where(a => a.Id == userName).FirstOrDefault();
            item.Online = false;
            _context.AspNetUsers.Update(item).Property(a => a.Id).IsModified = false;
            _context.SaveChanges();
            HttpContext.Session.Clear();
            return View("index");
        }
        [HttpPost]
        public IActionResult SaveAccount(AspNetUser aspNetUser)
        {
            if (_context.AspNetUsers.Any(a => a.UserName == aspNetUser.UserName) || _context.AspNetUsers.Any(a => a.Email == aspNetUser.Email))
            {
                ViewBag.Message = "email hoặc tên người dùng bị trùng, vui lòng nhập lại";
                return View("index");
            }
            else
            {
                aspNetUser.Id = RandomHelper.RandomString(10);
                aspNetUser.PasswordHash = BCrypt.Net.BCrypt.HashString(aspNetUser.PasswordHash.Trim());
                aspNetUser.Status = false;
                aspNetUser.SecurityStamp = RandomHelper.RandomString(6);
                _context.AspNetUsers.Add(aspNetUser);
                _context.SaveChanges();
                var mailHelper = new MailHelper(configuration);
                string content = "Code kích hoạt tài khoản là" + aspNetUser.SecurityStamp;
                mailHelper.Send("intimex.active@gmail.com", aspNetUser.Email, "Active account with code", content);
                HttpContext.Session.SetString("username", aspNetUser.UserName);
                return RedirectToAction("ActiveAccount");
            }
        }
        public IActionResult ActiveAccount()
        {
            ViewBag.userBranch = _context.Branches.Select(a => new { Id = a.Id }).ToList();
            ViewBag.userActive = HttpContext.Session.GetString("username");
            return View("ActiveAccount");
        }
        public IActionResult Active(string Activecode, AspNetUser aspNetUser)
        {

            var userName = HttpContext.Session.GetString("username");
            var account = _context.AspNetUsers.SingleOrDefault(a => a.UserName == userName);
            if (account.SecurityStamp == Activecode)
            {
                UserBranch userBranch = new UserBranch();
                account.Status = true;
                account.Online = true;
                account.UnitName = aspNetUser.UnitName;
                userBranch.UserName = userName;
                userBranch.BranchId = aspNetUser.UnitName;
                long maxId = _context.UserBranches.Max(a => a.UserBranchId);
                userBranch.UserBranchId = maxId + 1;
                _context.UserBranches.Add(userBranch);
                _context.AspNetUsers.Update(account);
                _context.SaveChanges();
                HttpContext.Session.SetString("userId", account.Id);
                HttpContext.Session.SetString("UserName", account.UserName);
                HttpContext.Session.SetString("fullName", account.NormalizedUserName);
                HttpContext.Session.SetString("UnitName", account.UnitName);
                ViewBag.Message = "Đăng ký thành công, mời đăng nhập";
                return View("Index");
            }
            else
            {
                ViewBag.Message = "Code sai!";
                return View("ActiveAccount");
            }
        }
    }
}
