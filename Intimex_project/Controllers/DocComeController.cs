using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class DocComeController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public DocComeController()
        {
        }

        public IActionResult DocCome()
        {
            return View("DocCome");
        }
        [HttpGet]
        public async Task<IActionResult>  Get(DataSourceLoadOptions loadOptions)
        {
            var item_return = _context.Documents.Select(i => new
            {
                i.DocId,
                i.DocDate,
                i.DateCome,
                i.NumberCome,
                i.Contents,
                i.DocTypeId,
                i.NumberSign,
                i.DocPlaceId,
                i.DocLever,
            });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
    }
}
