﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class BaoCaoGiaoBanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
