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

namespace pmkd.Controllers
{
    public class AccountController : Controller
    {
        Configuration config;
        private readonly tradingsystem_blContext _context = new tradingsystem_blContext("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=SignalRChat;Trusted_Connection=True;Integrated Security=SSPI;MultipleActiveResultSets=true");
        public AccountController()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userdetails = await _context.UserRights
                .SingleOrDefaultAsync(m => m.UserName1 == model.UserName1 && m.PassWord1 == model.PassWord1);
                if (userdetails == null)
                {
                    ViewBag.Message = "Sai tên tài khoản hoặc mật khẩu!";
                    ModelState.AddModelError("message", "Invalid login attempt.");
                    return View("index");
                }
                var userBranch = _context.UserBranches.Where(a => a.UserName == userdetails.UserName1).Count();
                if (userBranch > 1)
                {
                    ViewBag.userName = userdetails.UserName1;
                    ViewBag.password = userdetails.PassWord1;
                    ViewBag.userBranch = _context.UserBranches.Where(a => a.UserName == userdetails.UserName1).Select(a => new { BranchId = a.BranchId}).ToList();
                    return View("chooseBranch");
                }
                HttpContext.Session.SetString("userId", userdetails.UserName1);
                HttpContext.Session.SetString("FullName1", userdetails.FullName1);
                HttpContext.Session.SetString("UnitName", userdetails.UnitName);
            }
            else
            {
                return View("index");
            }
            
            return RedirectToAction("Index", "Home");
        }
        private void SaveConnectionString(string name,string connectionString)
        {
            var conStringSetting = new ConnectionStringSettings(name, connectionString);
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(conStringSetting);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appsettings");
        }
        private void SetDefaultConnectionString(string connectionStringName)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection section = config.GetSection("ConnectionStrings") as ConnectionStringsSection;
            section.ConnectionStrings["tradingsystem_blConnection"].ConnectionString = connectionStringName;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }
        public IActionResult loginwithUserBranch(LoginViewModel model)
        {
            var userdetails = _context.UserRights.SingleOrDefault(m => m.UserName1 == model.UserName1 && m.PassWord1 == model.PassWord1);
            var userBranch = model.userBranch;
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("ConnectionStrings");
            HttpContext.Session.SetString("userId", userdetails.UserName1);
            HttpContext.Session.SetString("FullName1", userdetails.FullName1);
            HttpContext.Session.SetString("UnitName", userBranch);
/*            if (userBranch == "INXBL")
            {
                SetDefaultConnectionString("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;MultipleActiveResultSets=true");
                return RedirectToAction("Index", "Home");
            }*/
            return RedirectToAction("Index", "Home");

        }

        // registration Page load
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("index");
        }

    }
    
}