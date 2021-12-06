using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class DocProcessController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DocProcess()
        {
            return View("DocProcess");
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec Sp_GetDocumentManage @UserName = "+ HttpContext.Session.GetString("UserName") + "";
            var item = _context.Sp_GetDocumentManages.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
    }
}
