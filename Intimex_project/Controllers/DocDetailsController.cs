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
    public class DocDetailsController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public IActionResult DocDetails()
        {
            return View("DocDetails");
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec sp_Document;28 @datefrom = '2012/01/01',"+
                        "@dateto = '"+ DateTime.Now.ToString("yyyy/MM/dd") +"'," +
                        "@DocStyle = '0',"+
                        "@DocType = '0'," +
                        "@Status = '0'," +
                        "@macn = '"+ HttpContext.Session.GetString("UnitName") + "',"+
                        "@User = '"+ HttpContext.Session.GetString("UserName") + "'";
            var item = _context.Sp_GetDocDetails.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
    }
}
