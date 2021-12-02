using Application.AutoId;
using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class ArchivesController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);

        public static List<ArchivesFbfileAttach> archivesFbfileAttaches = new List<ArchivesFbfileAttach>();

        private IHostEnvironment _env;
        public static List<string> ListHandler { get; set; } = new List<string>();

        public static List<string> ListParticipant { get; set; } = new List<string>();

        public ArchivesController(IHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Archives()
        {
            return View("Archives");
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec GetArchives " +
                            "@macn = " + HttpContext.Session.GetString("UnitName") + "," +
                            "@user = '" + HttpContext.Session.GetString("UserName") + "'";
            var item = _context.SP_GetArchives.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public IActionResult AddArchive()
        {
            ViewBag.Name = "Add";
            return PartialView("_PartiView_AddOrUpdate_Archive");
        }

        [HttpPost]
        public async Task<IActionResult> AddArchives(int ArchivesType,string ArchivesName,string Contents)
        {
            var returnCode = new SqlParameter();
            returnCode.ParameterName = "@ParamateOut";
            returnCode.DbType = System.Data.DbType.String;
            returnCode.Direction = System.Data.ParameterDirection.Output;
            returnCode.Size = 50;
            var Sp = "exec CreateNewIdBranch; 4 @TableName = 'CV',@Madonvi = 'INXBL',@UserId = 'CHIEN',@ParamateOut = @ParamateOut OUTPUT";
            var result = _context.Database.ExecuteSqlRaw(Sp,returnCode);
            var item = new Archive();
            item.ArchivesCode = returnCode.Value.ToString();
            item.ArchivesName = ArchivesName;
            item.MaCn = HttpContext.Session.GetString("UnitName");
            item.Contents = Contents;
            item.DateCreate = DateTime.Now;
            item.UserCreate = HttpContext.Session.GetString("UserName");
            item.IsFinish = false;
            item.ArchivesType = ArchivesType;
            item.DepId = (from a in _context.UserRights where a.UserName1 == HttpContext.Session.GetString("UserName") select a.Department).FirstOrDefault();
            await _context.Archives.AddAsync(item);
            await _context.SaveChangesAsync();
            TempData["alertMessage"] = "Thêm văn thư thành công";
            return RedirectToAction("Archives");
        }
        [HttpPost]
        public IActionResult EditArchive(long id)
        {
            ViewBag.name = "Edit";
            ViewBag.id = id;
            var item = _context.Archives.Where(a => a.ArchivesId == id).FirstOrDefault();
            return PartialView("_PartiView_AddOrUpdate_Archive", item);
        }
        [HttpPost]
        public async Task<IActionResult> EditArchive1(Archive archive,long id)
        {
            var arc = _context.Archives.Where(a => a.ArchivesId == id).FirstOrDefault();
            arc.ArchivesName = archive.ArchivesName;
            arc.Contents = archive.Contents;
            arc.ArchivesType = archive.ArchivesType;
            _context.Archives.Update(arc);
            await _context.SaveChangesAsync();
            TempData["alertMessage"] = "Cập nhật văn thư thành công";
            return RedirectToAction("Archives");
        }
        [HttpPost]
        public IActionResult AssignTask(long id)
        {
            ViewBag.id = id;
            var item = _context.Archives.Where(a => a.ArchivesId == id).FirstOrDefault();
            ViewBag.ArchivesCode = item.ArchivesCode;
            ViewBag.DateCreate = item.DateCreate;
            ViewBag.ArchivesName = item.ArchivesName;
            ViewBag.Contents = item.Contents;
            return PartialView("_PartiView_AssignTask");
        }
        [HttpGet]
        public object GetAssignTask(DataSourceLoadOptions loadOptions,long id)
        {
            var item_return = (from a in _context.ArchivesAssignTasks
                              where a.ArchivesId == id
                              select new
                              {
                                  ArchivesAssignTaskId = a.ArchivesAssignTaskId,
                                  DateAssign = a.DateAssign,
                                  DateFinishAssign = a.DateFinishAssign,
                                  UserAssign = _context.UserRights.Where(b => b.UserName1 == a.UserAssign).Select(a => a.FullName1).FirstOrDefault(),
                                  FullUserProcess = a.IsProcess == 1 ? _context.UserRights.Where(b => b.UserName1 == a.UserAccept).Select(a => a.FullName1).FirstOrDefault() : "",
                                  FullUserView = a.IsProcess == 0 ? _context.UserRights.Where(b => b.UserName1 == a.UserAccept).Select(a => a.FullName1).FirstOrDefault() : "",
                                  Contents = a.Contents,
                                  Note = a.Note
                              });
            var item = _context.ArchivesAssignTasks.Where(a => a.ArchivesId == id).ToList();
            return DataSourceLoader.Load(item_return, loadOptions);
        }
        [HttpPost]
        public ActionResult update_ListHandler(string[] array_ListHandler)
        {
            ListHandler.Clear();
            foreach (string i in array_ListHandler)
            {
                ListHandler.Add(i);
            }
            return Json("Update success");
        }
        [HttpPost]
        public ActionResult update_ListParticipant(string[] array_ListParticipant)
        {
            ListParticipant.Clear();
            foreach (string i in array_ListParticipant)
            {
                ListParticipant.Add(i);
            }
            return Json("Update success");
        }
        [HttpPost]
        public IActionResult AddAssignTask(long id,ArchivesAssignTask archivesAssignTask)
        {
            
            if (ListHandler.Count > 0)
            {
                for (var i = 0; i < ListHandler.Count; i++)
                {
                    if (_context.ArchivesAssignTasks.Where(a => a.UserAccept == ListHandler[i] && a.ArchivesId == id).Count() == 0)
                    {
                        var item = new ArchivesAssignTask();
                        item.DateCreate = DateTime.Now;
                        item.ArchivesId = id;
                        item.DateAssign = archivesAssignTask.DateAssign;
                        item.UserAssign = HttpContext.Session.GetString("UserName");
                        item.UserAccept = ListHandler[i];
                        item.Contents = archivesAssignTask.Contents;
                        item.IsProcess = 1;
                        item.DateFinishAssign = archivesAssignTask.DateFinishAssign;
                        item.Note = archivesAssignTask.Note;
                        _context.ArchivesAssignTasks.Add(item);
                        _context.SaveChanges();
                    }
                    else
                    {
                        var nv = _context.UserRights.Where(a => a.UserName1 == ListHandler[i]).Select(a => a.FullName1).FirstOrDefault();
                        TempData["alertMessage"] = "Nhân viên " + nv + " đã được giao việc";
                        return RedirectToAction("Archives");
                    }
                }
                ListHandler.Clear();
            }
            if (ListParticipant.Count > 0)
            {
                for (var i = 0; i < ListParticipant.Count; i++)
                {
                    if (_context.ArchivesAssignTasks.Where(a => a.UserAccept == ListParticipant[i] && a.ArchivesId == id).Count() == 0)
                    {
                        var item = new ArchivesAssignTask();
                        item.DateCreate = DateTime.Now;
                        item.ArchivesId = id;
                        item.DateAssign = archivesAssignTask.DateAssign;
                        item.UserAssign = HttpContext.Session.GetString("UserName");
                        item.UserAccept = ListParticipant[i];
                        item.Contents = archivesAssignTask.Contents;
                        item.IsProcess = 0;
                        item.DateFinishAssign = archivesAssignTask.DateFinishAssign;
                        item.Note = archivesAssignTask.Note;
                        _context.ArchivesAssignTasks.Add(item);
                        _context.SaveChanges();
                    }
                    else
                    {
                        var nv = _context.UserRights.Where(a => a.UserName1 == ListHandler[i]).Select(a => a.FullName1).FirstOrDefault();
                        TempData["alertMessage"] = "Nhân viên " + nv + " đã được giao việc";
                        return RedirectToAction("Archives");
                    }
                }
                ListParticipant.Clear();
            }
            TempData["alertMessage"] = "Giao việc cho văn thư thành công";
            return RedirectToAction("Archives");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAssignTask(string key)
        {
            var model = await _context.ArchivesAssignTasks.FirstOrDefaultAsync(item =>
                            item.ArchivesAssignTaskId == long.Parse(key));

            if (model.UserAssign != HttpContext.Session.GetString("UserName"))
            {
                return BadRequest("Bạn không có quyền xóa giao việc này");
            }
            else
            {
                _context.ArchivesAssignTasks.Remove(model);
                await _context.SaveChangesAsync();
                return Ok();
            }
            
        }
        [HttpPut]
        public IActionResult EditAssignTask(string key,string values)
        {
            var item = _context.ArchivesAssignTasks.FirstOrDefault(a => a.ArchivesAssignTaskId == long.Parse(key));
            
            if (item.UserAssign != HttpContext.Session.GetString("UserName"))
            {
                return BadRequest("Bạn không có quyền chỉnh sửa giao việc này");
            }
            else
            {
                JsonConvert.PopulateObject(values, item);
                _context.SaveChanges();
            }
            return Ok();
        }
       [HttpPost]
        public void DeleteList_handler(string id)
        {
            for (var i = 0; i < ListHandler.Count; i++)
            {
                if (ListHandler[i] == id)
                {
                    ListHandler.Remove(ListHandler[i]);
                }
            }
        }
        [HttpPost]
        public void DeleteList_participant(string id)
        {
            for (var i = 0; i < ListParticipant.Count; i++)
            {
                if (ListParticipant[i] == id)
                {
                    ListParticipant.Remove(ListParticipant[i]);
                }
            }
        }
        [HttpPost]
        public IActionResult DocArchive(long id)
        {
            ViewBag.ListFileAttach = _context.ArchivesFileAttaches.Where(a => a.ArchivesId == id).ToList();
            ViewBag.id = id;
            var item = _context.Archives.Where(a => a.ArchivesId == id).FirstOrDefault();
            ViewBag.ArchivesCode = item.ArchivesCode;
            ViewBag.DateCreate = item.DateCreate;
            ViewBag.ArchivesName = item.ArchivesName;
            ViewBag.Contents = item.Contents;
            return PartialView("_PartiView_DocArchive");
        }
        [HttpGet]
        public object GetDocument_HasArchive(long id,DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec Sp_GetDocument_Archive @ArchivesId = " + id + ", @user = " + HttpContext.Session.GetString("UserName") + ",@IsHasArchives = '1',@DocStyleId = '0',@DocTypeId = '0'";
            var item = _context.Sp_GetDocument_Archives.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetDocument_NoHasArchive(long id, DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec Sp_GetDocument_Archive @ArchivesId = " + id + ", @user = " + HttpContext.Session.GetString("UserName") + ",@IsHasArchives = '0',@DocStyleId = '0',@DocTypeId = '0'";
            var item = _context.Sp_GetDocument_Archives.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public void Add_file_attach(IEnumerable<IFormFile> files,string id)
        {
            foreach (var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\ArchivesFileAttach\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                string newFileName = AutoId.AutoIdFileStored("FileStored");
                string ext = Path.GetExtension(file.FileName);
                string newFile = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\DocCome\\{newFileName}{ext}";
                ArchivesFileAttach archivesFileAttach = new ArchivesFileAttach();
                archivesFileAttach.ArchivesId = long.Parse(id);
                archivesFileAttach.FileSource = file.FileName;
                archivesFileAttach.FileAttach = newFileName + ext;
                _context.ArchivesFileAttaches.Add(archivesFileAttach);
                _context.SaveChanges();
            }
        }
        public void DeleteFileAttach(string Id)
        {
            var extensionFile = _context.ArchivesFileAttaches.Where(a => a.Id == long.Parse(Id)).Select(a => a.FileSource).FirstOrDefault();
            string file = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\ArchivesFileAttach\\{extensionFile}";
            System.IO.File.Delete(file);
            var item = _context.ArchivesFileAttaches.Where(a => a.Id == long.Parse(Id)).FirstOrDefault();
            _context.ArchivesFileAttaches.Remove(item);
            _context.SaveChanges();
        }
        public async Task<IActionResult> DownloadDocument(string id)
        {
            var filename = id;
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/FileUploads/ArchivesFileAttach", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "APPLICATION/octet-stream", Path.GetFileName(path));
        }
        [HttpPost]
        public IActionResult Add_document_Archive(string[] array,string id)
        {
            foreach (string i in array)
            {
                DocArchive docArchive = new DocArchive();
                docArchive.DocId = long.Parse(i);
                docArchive.ArchivesId = long.Parse(id);
                _context.DocArchives.Add(docArchive);
                _context.SaveChanges();

            }
            return Json("Add document success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDocument_Archive(string key)
        {
            var model = await _context.DocArchives.FirstOrDefaultAsync(item =>
                            item.DocId == long.Parse(key));
            _context.DocArchives.Remove(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public IActionResult ArchiveFeedBack(long id)
        {
            ViewBag.ListFileAttach = _context.ArchivesFileAttaches.Where(a => a.ArchivesId == id).ToList();
            ViewBag.id = id;
            var item = _context.Archives.Where(a => a.ArchivesId == id).FirstOrDefault();
            ViewBag.ArchivesCode = item.ArchivesCode;
            ViewBag.DateCreate = item.DateCreate;
            ViewBag.ArchivesName = item.ArchivesName;
            ViewBag.Contents = item.Contents;
            return PartialView("_PartiView_ArchiveFeedBack");
        }
        [HttpPost]
        public void upLoadFilesFeedBack(IEnumerable<IFormFile> files)
        {
            foreach (var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\ArchivesFileFeedBack\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                string newFileName = AutoId.AutoIdFileStored("FileStored");
                string ext = Path.GetExtension(file.FileName);
                string newFile = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\ArchivesFileFeedBack\\{newFileName}{ext}";
                using (FileStream fileStream = System.IO.File.Create(newFile))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                archivesFbfileAttaches.Clear();
                archivesFbfileAttaches.Add(new ArchivesFbfileAttach { FileAttach = newFileName + ext, FileSource = file.FileName });
            }
        }
        [HttpPost]
        public IActionResult Add_ArchiveFeedBack(string id,ArchivesFeedBack archivesFeedBack)
        {
            ArchivesFeedBack archive = new ArchivesFeedBack();
            archive.Contents = archivesFeedBack.Contents;
            archive.IsFinish = archivesFeedBack.IsFinish;
            archive.ArchivesId = long.Parse(id);
            archive.UserCreate = HttpContext.Session.GetString("UserName");
            archive.DateCreate = DateTime.Now;
            _context.ArchivesFeedBacks.Add(archive);
            _context.SaveChanges();
            for(var i = 0;i < archivesFbfileAttaches.Count; i++)
            {
                ArchivesFbfileAttach attach = new ArchivesFbfileAttach();
                attach.ArchivesFbid = _context.ArchivesFeedBacks.Max(a => a.ArchivesFeedBackId);
                attach.FileAttach = archivesFbfileAttaches[i].FileAttach;
                attach.FileSource = archivesFbfileAttaches[i].FileSource;
                _context.ArchivesFbfileAttaches.Add(attach);
                _context.SaveChanges();
                archivesFbfileAttaches.Clear();
            }
            TempData["alertMessage"] = "Phản hồi công việc thành công";
            return RedirectToAction("Archives");
        }
    }

}
