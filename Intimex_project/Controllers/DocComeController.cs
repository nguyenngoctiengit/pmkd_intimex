using Application.AutoId;
using Application.DataLog;
using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class DocComeController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public static List<DocFileAttach> docFiles { get; set; } = new List<DocFileAttach>();

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
                                   IsChuyen = _context.DocProcesses.Count(b => b.DocId == a.DocId) > 0 ? true : false,
                                   Image = _context.DocFileAttaches.Where(b => b.DocId == a.DocId).Select(b => b.FileAttach).ToList()
                               });
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        public IActionResult AddDocCome()
        {
            return View("AddDocCome");
        }

        public void DeleteFile(string extensionFile)
        {
            string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{extensionFile}";
            System.IO.File.Delete(file);
            docFiles.RemoveAll(x => x.FileSource == extensionFile);
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
            var maxDocId = _context.Documents.Max(a => a.DocId);
            foreach(var item in docFiles)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{item.FileSource}";
                System.IO.File.Delete(fileName);
                DocFileAttach docFileAttach = new DocFileAttach();
                docFileAttach.DocId = maxDocId;
                docFileAttach.FileAttach = item.FileAttach;
                docFileAttach.FileSource = item.FileSource;
                await _context.DocFileAttaches.AddAsync(docFileAttach);
                await _context.SaveChangesAsync();
               
            }
            TempData["alertMessage"] = "Thêm văn bản đến thành công";
            return RedirectToAction("DocCome");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string key)
        {
            var model = await _context.Documents.FirstOrDefaultAsync(item =>
                            item.DocId == long.Parse(key));
            if (_context.DocProcesses.Any(a => a.DocId == model.DocId))
            {
                return BadRequest("Không thể xóa công văn đã gửi");
            }
            _context.Documents.Remove(model);
            await _context.SaveChangesAsync();
            var aaaa = UpdateDataLog.DisplayStates(_context.ChangeTracker.Entries());
            return Ok();
        }
    }
}
