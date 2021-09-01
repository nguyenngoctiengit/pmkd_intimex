using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Configuration;
using pmkd.AccountMail;
using Microsoft.AspNetCore.Authorization;
using pmkd.ModelService;
using pmkd.AppService;

namespace pmkd.Controllers
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
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginData loginData)
        {
            if (ModelState.IsValid)
            {
                string userId;
                if (new AppService.AppService().login(loginData,out userId))
                {
                    var user = _context.AspNetUsers.FirstOrDefault(a => a.UserName == loginData.Username);
                    HttpContext.Session.SetString("userId", user.Id);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Sai tài khoản hoặc mật khẩu";

                }
                return View("Index");
                /*if (processLogin(aspNetUser.UserName,aspNetUser.PasswordHash) == null)
                {
                    ViewBag.Message = "Sai tài khoản hoặc mật khẩu";
                    return View("Index");
                }
                else
                {
                    var userBranch = _context.UserBranches.Where(a => a.UserName == aspNetUser.UserName).Count();
                    if (userBranch > 1)
                    {
                        ViewBag.userName = aspNetUser.UserName;
                        ViewBag.userBranch = _context.UserBranches.Where(a => a.UserName == aspNetUser.UserName).Select(a => new { BranchId = a.BranchId }).ToList();
                        return View("chooseBranch");
                    }
                    else
                    {
                        var userdetails = _context.AspNetUsers.SingleOrDefault(m => m.UserName == aspNetUser.UserName && m.status == true);
                        return RedirectToAction("Index", "Home");
                    }
                }*/
            }
            else
            {
                ViewBag.Message = "Vui lòng điền tài khoản hoặc mật khẩu";
                return View("index");
            }
        }

        private AspNetUser processLogin(string username,string password)
        {
            var account = _context.AspNetUsers.SingleOrDefault(a => a.UserName == username && a.Status == true);
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.PasswordHash))
                {
                    account.Online = true;
                    _context.AspNetUsers.Update(account);
                    _context.SaveChanges();
                    HttpContext.Session.SetString("userId", account.UserName);
                    HttpContext.Session.SetString("FullName1", account.NormalizedUserName);
                    return account;
                }
            }
            return null;
        }

        public IActionResult loginwithUserBranch(AspNetUser aspNetUser)
        {
            var userdetails = _context.AspNetUsers.SingleOrDefault(m => m.UserName == aspNetUser.UserName && m.Status == true);
            var userBranch = aspNetUser.UnitName;
            userdetails.Online = true;
            _context.AspNetUsers.Update(userdetails).Property(a => a.Id).IsModified = false;
            _context.SaveChanges();
            if (userBranch == "INXBL")
            {                
                HttpContext.Session.SetString("UnitName", "INXBL");
                Parameter.connectionString = "Server=.\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;MultipleActiveResultSets=true";
                return RedirectToAction("Index", "Home");
            }
            else if (userBranch == "INX")
            {
                HttpContext.Session.SetString("UnitName", "INX");
                Parameter.connectionString = "Server=.\\SQLEXPRESS;Database=tradingsystem;Trusted_Connection=True;MultipleActiveResultSets=true";
                return RedirectToAction("Index", "Home");
            }
            Parameter.connectionString = "Server=.\\SQLEXPRESS;Database=tradingsystem;Trusted_Connection=True;MultipleActiveResultSets=true";
            return RedirectToAction("Index", "Home");

        }

        // registration Page load
        public IActionResult Logout()
        {
            var userName = HttpContext.Session.GetString("userId");
            var item = _context.AspNetUsers.Where(a => a.UserName == userName).FirstOrDefault();
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
        public IActionResult Active(string Activecode,AspNetUser aspNetUser)
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
                HttpContext.Session.SetString("userId", account.UserName);
                HttpContext.Session.SetString("FullName1", account.NormalizedUserName);
                HttpContext.Session.SetString("UnitName", account.UnitName);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Code sai!";
                return View("ActiveAccount");
            }
        }
    }

}