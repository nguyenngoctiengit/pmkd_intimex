using Application.AutoId;
using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "EXEC sp_Document;2 @DocStyleId = ''," +
                            "@DateFrom = '2012-01-01'," +
                            "@DateTo = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                            "@DocTypeId = '0'," +
                            "@SignNumber = ''," +
                            "@User = '" + HttpContext.Session.GetString("UserName") + "'," +
                            "@IsChuyen = '2'," +
                            "@macn = '" + HttpContext.Session.GetString("UnitName") + "'";
            var item = _context.Sp_GetDocComes.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public async Task<IActionResult> DownloadDocument(string id)
        {
            var filename = id;
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/FileUploads/DocGo", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "APPLICATION/octet-stream", Path.GetFileName(path));
        }
        public IActionResult AddDocGo()
        {
            return PartialView("_PartiView_AddDocGo");
        }

        [HttpPost]
        public void upLoadFiles(IEnumerable<IFormFile> files)
        {
            docFiles.Clear();
            docFilesEdit.Clear();
            foreach (var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Document\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                string newFileName = AutoId.AutoIdFileStored("FileStored");
                string ext = Path.GetExtension(file.FileName);
                string newFile = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Document\\{newFileName}{ext}";
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
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Document\\{item.FileSource}";
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
            return PartialView("_PartiView_EditDocGo", model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit_DocGo(string id, Document document)
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
                string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Document\\{extensionFile}";
                System.IO.File.Delete(file);
                var delete_item = _context.DocFileAttaches.FirstOrDefault(a => a.FileAttach == extensionFile);
                _context.DocFileAttaches.Remove(delete_item);
                _context.SaveChanges();
            }
            else
            {
                string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Document\\{extensionFile}";
                System.IO.File.Delete(file);
                docFilesEdit.RemoveAll(x => x.FileSource == extensionFile);
            }

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
            model.IsDelete = true;
            _context.Documents.Update(model);
            await _context.SaveChangesAsync();
            TempData["alertMessage"] = "Xóa văn bản đến thành công";
            return Ok();
        }
        [HttpPost]
        public ActionResult addarchive1(string[] array, long DocId)
        {
            List<string> listArchive = new List<string>();
            foreach (string i in array)
            {

                listArchive.Add(i);

            }
            for (var i = 0; i < listArchive.Count(); i++)
            {
                DocArchive doc = new DocArchive();
                doc.DocId = DocId;
                doc.ArchivesId = long.Parse(listArchive[i]);
                _context.DocArchives.Add(doc);
                _context.SaveChanges();
            }
            listArchive.Clear();
            TempData["alertMessage"] = "Lưu văn bản đến thành công";
            return Json(Url.Action("DocGo", "DocGo"));
        }
    }
}
