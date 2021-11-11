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

        public static List<DocFileAttach> docFilesEdit { get; set; } = new List<DocFileAttach>();

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
                                   IsChuyen = _context.DocProcesses.Count(b => b.DocId == a.DocId) > 0 ? true : false,
                                   Image = _context.DocFileAttaches.Where(b => b.DocId == a.DocId).Select(b => b.FileAttach).ToList()
                               }).OrderByDescending(a => a.DocDate);
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

        public void DeleteFileEdit(string extensionFile)
        {
            if (extensionFile.StartsWith("F000"))
            {
                string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{extensionFile}";
                System.IO.File.Delete(file);
                var delete_item = _context.DocFileAttaches.FirstOrDefault(a => a.FileAttach == extensionFile);
                _context.DocFileAttaches.Remove(delete_item);
                _context.SaveChanges();
            }
            else
            {
                string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{extensionFile}";
                System.IO.File.Delete(file);
                docFilesEdit.RemoveAll(x => x.FileSource == extensionFile);
            }
            
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
                string newFileName = AutoId.AutoIdFileStored("FileStored");
                string ext = Path.GetExtension(file.FileName);
                string newFile = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{newFileName}{ext}";
                using (FileStream fileStream = System.IO.File.Create(newFile))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                docFiles.Add(new DocFileAttach { FileAttach = newFileName + ext, FileSource = file.FileName });
                docFilesEdit.Add(new DocFileAttach { FileAttach = newFileName + ext, FileSource = file.FileName });
            }
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
            return Ok();
        }
        public IActionResult EditDocCome(string id)
        {
            ViewBag.DocId = id;
            ViewBag.listImage = _context.DocFileAttaches.Where(a => a.DocId == long.Parse(id)).ToList();
            var model = _context.Documents.Where(a => a.DocId == long.Parse(id)).FirstOrDefault();
            return View("EditDocCome",model);
        }
        [HttpPost]
        public async Task<IActionResult>  EditDocCome(string id,Document document)
        {
            var _document = _context.Documents.FirstOrDefault(a => a.DocId == long.Parse(id));
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
            TempData["alertMessage"] = "Chỉnh sửa văn bản đến thành công";
            return RedirectToAction("DocCome");
        }
        public IActionResult addarchive(long id)
        {
            ViewBag.DocId = id;
            return View("addarchive");
        }
        [HttpGet]
        public async Task<IActionResult> GetArchive(string id, DataSourceLoadOptions loadOptions)
        {

            var item_return = from a in _context.Archives
                              where a.MaCn == HttpContext.Session.GetString("UnitName")
                              && !(from b in _context.DocArchives where b.DocId == long.Parse(id) select b.ArchivesId).Contains(a.ArchivesId)
                              select new
                              {
                                  ArchivesId = a.ArchivesId,
                                  ArchivesName = a.ArchivesName,
                                  IsFinish = a.IsFinish == true ? "Hoàn thành" : "Chưa hoàn thành",
                                  ArchivesType = a.ArchivesType == 0 ? "Công việc" : a.ArchivesType == 1 ? "Hồ sơ" : "Tất cả",
                              };
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
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
            TempData["alertMessage"] = "Lưu văn bản đến thành công";
            return Json(Url.Action("DocCome", "Doccome"));
        }
        public IActionResult DocTransfer(long id)
        {
            ViewBag.DocId = id;
            return View("DocTransfer");
        }
/*        [HttpGet]
        public async Task<IActionResult> GetUserRight(DataSourceLoadOptions loadOptions)
        {

            var item_return = from a in _context.UserRights select new
            {
                a.UserName1,
                a.FullName1,

            }
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }*/

    }
}
