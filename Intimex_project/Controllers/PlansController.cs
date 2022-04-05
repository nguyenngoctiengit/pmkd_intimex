using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class PlansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPlans(string id)
        {
            return View("AddPlans");
        }
        public IActionResult AddPlans_Bootstrap(string id)
        {
            return View("_Content_bootstrap_Plans");
        }
    }
}
