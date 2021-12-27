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
using Application.Eoffice;

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
        [HttpPost]
        public IActionResult DisplayNameReceive(long DocId,long IsFeedBack)
        {
            if (IsFeedBack == 0)
            {
                var listUserReceive = (from a in _context.DocProcesses join b in _context.UserRights on a.ObjectProcess equals b.UserName1
                                       join c in _context.Departments on b.Department equals c.DepartmentId where a.DocId == DocId select new {
                                           b.FullName1,
                                           c.DepartmentCode

                                       }).ToList();
                return Json(listUserReceive);
            }
            else
            {
                var listUserReceive = (from a in _context.DocProcesses
                                       join b in _context.DocFeedBacks on a.DocProcessId equals b.DocProcessId
                                       join c in _context.UserRights on b.UserReceive equals c.UserName1
                                       join d in _context.Departments on c.Department equals d.DepartmentId where a.DocId == DocId && b.UserSend == HttpContext.Session.GetString("UserName")
                                       select new {

                                           c.FullName1,
                                           d.DepartmentCode

                                       }).ToList();
                return Json(listUserReceive);
            }
            
        }
        [HttpPost]
        public IActionResult ViewImage(long DocId)
        {

            if (DocDetail.CheckUserViewImage(DocId, HttpContext.Session.GetString("UserName")) == true)
            {
                ViewBag.ListImage = _context.DocFileAttaches.Where(a => a.DocId == DocId).ToList();
                return PartialView("_PartiView_ViewFileDocument");
            }
            else
            {
                return Json("false");
            }
        }
    }
}
