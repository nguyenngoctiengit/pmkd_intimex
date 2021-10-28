using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Http;
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
            var item_return = (from a in _context.Documents
                               select new
                               {
                                   DocId = a.DocId,
                                   DocDate = a.DocDate,
                                   DateCome = a.DateCome,
                                   NumberCome = a.NumberCome,
                                   Contents = a.Contents,
                                   DocTypeId = a.DocTypeId,
                                   NumberSign = a.NumberSign,
                                   DocPlaceId = a.DocPlaceId,
                                   DocLever = a.DocLever,
                                   IsChuyen = _context.DocProcesses.Count(b => b.DocId == a.DocId) > 0 ? true : false
                               });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public IActionResult AddDocCome()
        {
            return View("AddDocCome");
        }
        public async Task<IActionResult> add_doccome(Document document)
        {
            Document _document = new Document();
            _document.DateCreate = DateTime.Now;
            _document.DocLever = document.DocLever;
            _document.NumberCome = document.NumberCome;
            _document.DocDate = document.DocDate;
            _document.NumberOfPage = document.NumberOfPage;
            _document.NumberSign = document.NumberSign;
            _document.DateCome = document.DateCome;
            _document.DocTypeId = document.DocTypeId;
            _document.DocPlaceId = document.DocPlaceId;
            _document.Contents = document.Contents;
            _document.Note = document.Note;
            _document.Singer = "";
            _document.UserCreate = HttpContext.Session.GetString("userId");
            _document.Macn = HttpContext.Session.GetString("UnitName");
            await _context.Documents.AddAsync(_document);
            await _context.SaveChangesAsync();
            TempData["alertMessage"] = "thêm văn bản đến thành công";
            return RedirectToAction("DocCome");
        }
    }
}
