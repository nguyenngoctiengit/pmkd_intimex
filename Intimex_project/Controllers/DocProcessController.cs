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
            var Sp = "exec [dbo].[sp_Document];12 @DocStyleId = '0',"+
                        "@DateFrom = '2012/01/01',"+
                        "@DateTo = '"+ DateTime.Now.ToString("yyyy/MM/dd") +"',"+
                        "@DocTypeId = '0',"+
                        "@SignNumber = '',"+
                        "@StatusProcess = '2',"+
                        "@UserName = '"+ HttpContext.Session.GetString("UserName") + "',"+
                        "@DocProcessId = '0',"+
                        "@StatusDoc = '2'";
            var item = _context.Sp_GetDocumentManages.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
    }
}
