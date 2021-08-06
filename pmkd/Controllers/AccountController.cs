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
        private readonly tradingsystem_blContext _context;

        public IConfiguration Configuration;

        public AccountController(tradingsystem_blContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
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
        public IActionResult loginwithUserBranch(LoginViewModel model,DbContextOptionsBuilder optionsBuilder)
        {
            var userdetails = _context.UserRights.SingleOrDefault(m => m.UserName1 == model.UserName1 && m.PassWord1 == model.PassWord1);
            var userBranch = model.userBranch;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("ConnectionStrings");
            HttpContext.Session.SetString("userId", userdetails.UserName1);
            HttpContext.Session.SetString("FullName1", userdetails.FullName1);
            HttpContext.Session.SetString("UnitName", userBranch);
            if (userBranch == "INXBL")
            {
                string connectTionString = string.Format("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;pooling=false;Timeout=60;Integrated Security=SSPI;MultipleActiveResultSets=true");
                try
                {
                    var cn = Configuration.GetConnectionString("tradingsystem_blConnection");
                    connectionStringsSection.ConnectionStrings["tradingsystem_blConnection"].ConnectionString  = connectTionString;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                }
                catch
                {
                    return View("index");
                }
            }
            ViewBag.mess = "Connect database fail";
            return View("index");

        }

        // registration Page load
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("index");
        }

    }
    
}