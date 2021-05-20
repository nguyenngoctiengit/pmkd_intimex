using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class QuanLiNhanSuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult thongtinnhansu()
        {
            return View("thongtinnhansu");
        }
    }
}
