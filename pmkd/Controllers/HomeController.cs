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
/*        private readonly tradingsystem_blContext _context = new tradingsystem_blContext(ConfigurationManager.ConnectionStrings["tradingsystem_blConnection_bl"].ConnectionString);*/

        public HomeController(tradingsystem_blContext context)
        {
        }
        public void CheckConnection()
        {
            if (HttpContext.Session.GetString("UnitName") == "INXBL")
            {
                using (tradingsystem_blContext _context = new tradingsystem_blContext("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;pooling=false;Timeout=60;Integrated Security=SSPI;MultipleActiveResultSets=true"));
            }
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UnitName") == "INXBL")
            {
                using (tradingsystem_blContext _context = new tradingsystem_blContext("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;pooling=false;Timeout=60;Integrated Security=SSPI;MultipleActiveResultSets=true"))
                {
                    var id = HttpContext.Session.Get("userId");
                    if (id != null)
                    {
                        ViewBag.mess = "CS";
                        ViewBag.countuser = (from a in _context.UserRights select a.UserId).Count();
                        return View();
                    }
                    else
                    {

                        return RedirectToAction("index", "Account");
                    }
                }
            }
            return RedirectToAction("index", "Account");

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
