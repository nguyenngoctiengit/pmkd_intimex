using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace pmkd.Controllers
{
    public class AccountController : Controller
    {
        private readonly tradingsystem_blContext _context;

        public AccountController(tradingsystem_blContext context)
        {
            _context = context;
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


        // registration Page load
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("index");
        }

    }
    
}