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

namespace pmkd.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var id = HttpContext.Session.Get("userId");
            if(id != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("index", "Account");
            }

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
