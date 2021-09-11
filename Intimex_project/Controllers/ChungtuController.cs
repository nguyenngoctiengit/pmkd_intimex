using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class ChungtuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
