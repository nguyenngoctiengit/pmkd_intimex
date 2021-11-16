using Application.AutoId;
using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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
    public class DocGoController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public static List<DocFileAttach> docFiles { get; set; } = new List<DocFileAttach>();

        public static List<DocFileAttach> docFilesEdit { get; set; } = new List<DocFileAttach>();

        public static List<string> ListReciever { get; set; } = new List<string>();

        private IHostEnvironment _env;

        public DocGoController(IHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DocGo()
        {
            return View("DocGo");
        }
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            var item_return = (from a in _context.Documents
                               where a.DocStyleId != 3
                               select new
                               {
                                   DateCreate = a.DateCreate,
                                   DocId = a.DocId,
                                   DocDate = a.DocDate,
                                   DateCome = a.DateCome,
                                   NumberCome = a.NumberCome,
                                   Contents = a.Contents,
                                   DocTypeId = a.DocTypeId,
                                   NumberSign = a.NumberSign,
                                   DocPlaceId = a.DocPlaceId,
                                   DocLever = a.DocLever,
                                   Singer = a.Singer,
                                   DocStyleId = a.DocStyleId == 2 ? "Gửi nội bộ" : "Gửi ra ngoài",
                                   IsChuyen = _context.DocProcesses.Count(b => b.DocId == a.DocId) > 0 ? true : false,
                               }).OrderByDescending(a => a.DocDate);
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }

        public IActionResult AddDocGo()
        {
            return View("AddDocGo");
        }

        [HttpPost]
        public void upLoadFiles(IEnumerable<IFormFile> files)
        {
            foreach (var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocGo\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                string newFileName = AutoId.AutoIdFileStored("FileStored");
                string ext = Path.GetExtension(file.FileName);
                string newFile = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocGo\\{newFileName}{ext}";
                using (FileStream fileStream = System.IO.File.Create(newFile))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                docFiles.Add(new DocFileAttach { FileAttach = newFileName + ext, FileSource = file.FileName });
                docFilesEdit.Add(new DocFileAttach { FileAttach = newFileName + ext, FileSource = file.FileName });
            }
        }
        public async Task<IActionResult> add_docgo(Document document)
        {
            Document _document = new Document();
            _document.DateCreate = DateTime.Now;
            _document.DocLever = document.DocLever;
            _document.NumberCome = "";
            _document.DocDate = document.DocDate;
            _document.NumberOfPage = document.NumberOfPage;
            _document.NumberSign = document.NumberSign;
            _document.DateCome = DateTime.Now;
            _document.DocTypeId = document.DocTypeId;
            _document.DocPlaceId = document.DocStyleId == 1 ? document.DocPlaceId : 0;
            _document.Contents = document.Contents;
            _document.Note = document.Note;
            _document.Singer = document.Singer;
            _document.DocStyleId = document.DocStyleId;
            _document.IsPublic = 0;
            _document.UserCreate = HttpContext.Session.GetString("UserName");
            _document.Macn = HttpContext.Session.GetString("UnitName");
            await _context.Documents.AddAsync(_document);
            await _context.SaveChangesAsync();
            var maxDocId = _context.Documents.Max(a => a.DocId);
            foreach (var item in docFiles)
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
            return RedirectToAction("DocGo");
        }
        public IActionResult EditDocGo(string id)
        {
            ViewBag.DocId = id;
            ViewBag.listImage = _context.DocFileAttaches.Where(a => a.DocId == long.Parse(id)).ToList();
            var model = _context.Documents.Where(a => a.DocId == long.Parse(id)).FirstOrDefault();
            return View("EditDocGo", model);
        }
        [HttpPost]
        public async Task<IActionResult> EditDocGo(string id, Document document)
        {
            var _document = _context.Documents.FirstOrDefault(a => a.DocId == long.Parse(id));
            _document.DocLever = document.DocLever;
            _document.DocDate = document.DocDate;
            _document.NumberOfPage = document.NumberOfPage;
            _document.NumberSign = document.NumberSign;
            _document.DateCome = document.DateCome;
            _document.DocTypeId = document.DocTypeId;
            _document.DocPlaceId = document.DocStyleId == 1 ? document.DocPlaceId : 0;
            _document.Contents = document.Contents;
            _document.Note = document.Note;
            _context.Documents.Update(_document);
            await _context.SaveChangesAsync();
            foreach (var item in docFilesEdit)
            {
                DocFileAttach docFileAttach = new DocFileAttach();
                docFileAttach.DocId = long.Parse(id);
                docFileAttach.FileAttach = item.FileAttach;
                docFileAttach.FileSource = item.FileSource;
                await _context.DocFileAttaches.AddAsync(docFileAttach);
                await _context.SaveChangesAsync();

            }
            docFilesEdit.Clear();
            TempData["alertMessage"] = "Chỉnh sửa văn bản đến thành công";
            return RedirectToAction("DocGo");
        }
        public void DeleteFileEdit(string extensionFile)
        {
            if (extensionFile.StartsWith("F000"))
            {
                string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocGo\\{extensionFile}";
                System.IO.File.Delete(file);
                var delete_item = _context.DocFileAttaches.FirstOrDefault(a => a.FileAttach == extensionFile);
                _context.DocFileAttaches.Remove(delete_item);
                _context.SaveChanges();
            }
            else
            {
                string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocGo\\{extensionFile}";
                System.IO.File.Delete(file);
                docFilesEdit.RemoveAll(x => x.FileSource == extensionFile);
            }

        }
    }
}
