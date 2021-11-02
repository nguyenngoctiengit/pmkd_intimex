using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
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

        private IHostEnvironment _env;
        public DocComeController(IHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult DocCome()
        {
            return View("DocCome");
        }
        [HttpGet]
        public async Task<IActionResult>  Get(DataSourceLoadOptions loadOptions)
        {
            var item_return = (from a in _context.Documents join b in _context.DocFileAttaches on a.DocId equals b.DocId into dfa
                               from b in dfa.DefaultIfEmpty()
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
                                   IsChuyen = _context.DocProcesses.Count(b => b.DocId == a.DocId) > 0 ? true : false,
                                   Image = b.FileSource
                               });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public IActionResult AddDocCome()
        {
            return View("AddDocCome");
        }
        [HttpPost]
        public void upLoadFiles(IEnumerable<IFormFile> files)
        {
            foreach (var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                     file.CopyTo(fileStream);
                     fileStream.Flush();
                }
            }
        }
        public async Task<IActionResult> add_doccome(Document document,IEnumerable<IFormFile> files)
        {
            var maxDocId = _context.Documents.Max(a => a.DocId);
            foreach(var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    await file.CopyToAsync(fileStream);
                    await fileStream.FlushAsync();
                }
                DocFileAttach docFileAttach = new DocFileAttach();
                docFileAttach.DocId = maxDocId + 1;
                docFileAttach.FileAttach = file.FileName;
                docFileAttach.FileSource = file.FileName;
                await _context.DocFileAttaches.AddAsync(docFileAttach);
                await _context.SaveChangesAsync();

            }
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
