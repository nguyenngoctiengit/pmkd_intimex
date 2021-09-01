﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly tradingsystem_blContext _context = new tradingsystem_blContext(Parameter.connectionString);

        public HomeController(tradingsystem_blContext context)
        {
        }
        public void listUser()
        {
            using (SignalRChatContext _context = new SignalRChatContext())
            {
                ViewBag.ListUser = (from a in _context.AspNetUsers select new AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online, Id = a.Id }).OrderByDescending(a => a.Online).ToList();
            }
        }
        public IActionResult Index()
        {

            using (SignalRChatContext _context = new SignalRChatContext())
            {
                var id = HttpContext.Session.GetString("userId");
                if (id != null)
                {
                    ViewBag.CountUserOnline = (from a in _context.AspNetUsers where a.Online == true select a.NormalizedUserName).Count();
                    listUser();
                    ViewBag.countuser = (from a in _context.UserRights select a.UserId).Count();
                    return View();
                }
                else
                {

                    return RedirectToAction("index", "Account");
                }
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
        public IActionResult chat(string id)
        {
            listUser();
            return View("chat");
        }
    }
}
