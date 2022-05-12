using Application.AutoId;
using Application.Eoffice;
using Application.Parameter;
using Data.Models.Trading_system;
using Data.Public_class;
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
using Application.AppServices;

namespace Intimex_project.Controllers
{
    public class DocComeController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public static List<DocFileAttach> docFiles { get; set; } = new List<DocFileAttach>();
        public static List<DocFileAttach> docFilesEdit { get; set; } = new List<DocFileAttach>();
        public static List<string> ListReciever { get; set; } = new List<string>();

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
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "EXEC sp_Document;2 @DocStyleId = '3',"+
                            "@DateFrom = '2012-01-01',"+
                            "@DateTo = '"+ DateTime.Now.ToString("yyyy-MM-dd") +"',"+
                            "@DocTypeId = '0',"+
                            "@SignNumber = '',"+
                            "@User = '" + HttpContext.Session.GetString("UserName") + "',"+
                            "@IsChuyen = '2',"+
                            "@macn = '"+ HttpContext.Session.GetString("UnitName") + "'";
            var item = _context.Sp_GetDocComes.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public IActionResult AddDocCome()
        {
            return PartialView("_PartiView_AddDocCome");
        }

        public void DeleteFile(string extensionFile)
        {
            string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\Document\\{extensionFile}";
            System.IO.File.Delete(file);
            docFiles.RemoveAll(x => x.FileSource == extensionFile);
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
        [HttpPost]
        public void upLoadFiles(IEnumerable<IFormFile> files)
        {
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
            _document.DocStyleId = 3;
            _document.UserCreate = HttpContext.Session.GetString("UserName");
            _document.Macn = HttpContext.Session.GetString("UnitName");
            await _context.Documents.AddAsync(_document);
            await _context.SaveChangesAsync();
            var maxDocId = _context.Documents.Max(a => a.DocId);
            foreach(var item in docFiles)
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
            docFiles.Clear();
            docFilesEdit.Clear();
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
            model.IsDelete = true;
            _context.Documents.Update(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public IActionResult EditDocCome(string DocId)
        {
            ViewBag.DocId = DocId;
            ViewBag.listImage = _context.DocFileAttaches.Where(a => a.DocId == long.Parse(DocId)).ToList();
            var model = _context.Documents.Where(a => a.DocId == long.Parse(DocId)).FirstOrDefault();
            return PartialView("_PartiView_EditDocCome", model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit_DocCome(Document document, string id)
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
            docFiles.Clear();
            docFilesEdit.Clear();
            TempData["alertMessage"] = "Chỉnh sửa văn bản đến thành công";
            return RedirectToAction("DocCome");
        }
        public IActionResult addarchive(long DocId)
        {
            ViewBag.DocId = DocId;
            return PartialView("_PartiView_AddArchive");
        }
        [HttpGet]
        public object GetArchive(string DocId, DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec sp_Document;18 @MaCN = '"+ HttpContext.Session.GetString("UnitName") + "',"+
                        "@DocId = '"+ DocId + "',"+
                        "@Status = '2',"+
                        "@UserName = '" + HttpContext.Session.GetString("UserName") + "',"+
                        "@ArchivesType = '2'";
            var item = _context.Sp_GetArchivesForAdds.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public ActionResult addarchive1(string[] array, long id)
        {
            List<string> listArchive = new List<string>();
            foreach (string i in array)
            {

                listArchive.Add(i);

            }
            for (var i = 0; i < listArchive.Count(); i++)
            {
                DocArchive doc = new DocArchive();
                doc.DocId = id;
                doc.ArchivesId = long.Parse(listArchive[i]);
                _context.DocArchives.Add(doc);
                _context.SaveChanges();
            }
            listArchive.Clear();
            TempData["alertMessage"] = "Lưu văn bản đến thành công";
            return Json(Url.Action("DocCome", "Doccome"));
        }
        [HttpPost]
        public IActionResult DocTransfer(long DocId)
        {
            var document = _context.Documents.Where(a => a.DocId == DocId).FirstOrDefault();
            ViewBag.NumberSign = document.NumberSign;
            ViewBag.DocDate = document.DocDate;
            ViewBag.DocType = _context.DocTypes.Where(a => a.DocTypeId == document.DocTypeId).Select(a => a.TypeName).FirstOrDefault();
            ViewBag.Contents = document.Contents;
            ViewBag.DocId = DocId;
            return PartialView("_PartiView_DocTranfer");
        }
        [HttpGet]
        public async Task<IActionResult> GetUserRight(DataSourceLoadOptions loadOptions)
        {

            var item_return = from a in _context.UserRights
                              join b in _context.Departments on a.Department equals b.DepartmentId
                              join c in _context.Branches on b.BranchId equals c.Id
                              select new
                              {
                                  FullName1 = a.FullName1,
                                  UserName1 = a.UserName1,
                                  BranchId = b.DepartmentName,
                                  NameV = c.NameV,
                              };
            return Json(await DataSourceLoader.LoadAsync(item_return, loadOptions));
        }
        [HttpPost]
        public ActionResult update_ListReciever(string[] array_ListReciever)
        {
            ListReciever.Clear();
            foreach (string i in array_ListReciever)
            {
                ListReciever.Add(i);
            }
            return Json("Update success");
        }
        public int FindMaxList(List<Notification> notifications)
        {
            if (notifications.Count == 0)
            {
                return 0;
            }
            int maxId = int.MinValue;
            foreach (Notification notification in notifications)
            {
                if (notification.id > maxId)
                {
                    maxId = notification.id;
                }
            }
            return maxId;
        }
        [HttpPost]
        public async Task<IActionResult> Doc_Transfer(DocProcess docProcess,long id)
        {
            DocProcess doc = new DocProcess();
            for (var i = 0;i< ListReciever.Count; i++)
            {
                doc.DocProcessId = 0;
                doc.UserSend = HttpContext.Session.GetString("UserName");
                doc.DocId = id;
                doc.ObjectProcess = ListReciever[i];
                doc.DateLimit = docProcess.DateLimit;
                doc.DateReceive = DateTime.Now;
                doc.StatusProcess = 1;
                doc.Command = docProcess.Command == null ? "" : docProcess.Command;
                await _context.DocProcesses.AddAsync(doc);
                await _context.SaveChangesAsync();
                var test = FindMaxList(NotificationList.notifications);
                var nguoiGui = _context.UserRights.Where(a => a.UserName1 == doc.UserSend).Select(a => a.FullName1).FirstOrDefault();
                UpdateListMessage.UpdateMessage(1, doc.UserSend, doc.ObjectProcess, nguoiGui, "Văn bản nhận được: " + id);
            }
            ListReciever.Clear();
            var docStyle = _context.Documents.Where(a => a.DocId == id).Select(a => a.DocStyleId).FirstOrDefault();
            if (docStyle == 3)
            {
                TempData["alertMessage"] = "Gửi văn bản đến thành công";
                return RedirectToAction("DocCome");
            }
            else
            {
                TempData["alertMessage"] = "Gửi văn bản đi thành công";
                return RedirectToAction("DocGo","DocGo");
            }
            
        }

        [HttpPost]
        public void DeleteReceiver(string id)
        {
            for(var i = 0;i < ListReciever.Count; i++)
            {
                if (ListReciever[i] == id)
                {
                    ListReciever.Remove(ListReciever[i]);
                }
            }
        }
        public async Task<IActionResult> DownloadDocument(string id)
        {
            var filename = id;
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/FileUploads/Document", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "APPLICATION/octet-stream", Path.GetFileName(path));
        }
        [HttpPost]
        public IActionResult AddDocPlace1(string DocPlaceCode,string DocPlaceName, string Address, string Phone, string Email)
        {
            var DocPlace = new DocPlace();
            DocPlace.DocPlaceCode = DocPlaceCode;
            DocPlace.DocPlaceName = DocPlaceName;
            DocPlace.Address = Address;
            DocPlace.Phone = Phone;
            DocPlace.Email = Email;
            _context.DocPlaces.Add(DocPlace);
            _context.SaveChanges();
            return Json("Thêm nơi gửi thành công");
        }
    }
}
