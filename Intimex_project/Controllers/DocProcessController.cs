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
    public class DocProcessController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);

        private IHostEnvironment _env;

        public static List<FeedBackFileAttach> ListFileAttachFeedback { get; set; } = new List<FeedBackFileAttach>();
        public DocProcessController(IHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DocProcess()
        {
            return View("DocProcess");
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec [dbo].[sp_Document];12 @DocStyleId = '0',"+
                        "@DateFrom = '2012/01/01',"+
                        "@DateTo = '"+ DateTime.Today.AddDays(1).ToString("yyyy/MM/dd") +"',"+
                        "@DocTypeId = '0',"+
                        "@SignNumber = '',"+
                        "@StatusProcess = '2',"+
                        "@UserName = '"+ HttpContext.Session.GetString("UserName") + "',"+
                        "@DocProcessId = '0',"+
                        "@StatusDoc = '2'";
            var item = _context.Sp_GetDocumentManages.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
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
            return Json(Url.Action("DocProcess", "DocProcess"));
        }
        public IActionResult DocFeedBack(string DocId,string DocProcessId)
        {
            ViewBag.ListFileAttach = _context.DocFileAttaches.Where(a => a.DocId == long.Parse(DocId)).ToList();
            ViewBag.DocProcessId = DocProcessId;
            ViewBag.Contents = _context.Documents.Where(a => a.DocId == long.Parse(DocId)).Select(a => a.Contents).FirstOrDefault();
            return PartialView("_PartiView_DocFeedBack");
        }
        [HttpGet]
        public object GetDocFeedBack(string DocProcessId,DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec sp_Document;15 @DocProcessId = '"+ DocProcessId +"',"+
                     "@DocFeedBackParentId = '0',"+
                     "@User = '"+ HttpContext.Session.GetString("UserName") + "'";
            var item = _context.Sp_GetDocFeedbacks.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public ActionResult SaveDocFeedBack(string[] array_ListReciever,string DocProcessId,string Idea,long FeedbackId)
        {
            foreach(var i in array_ListReciever)
            {
                if (CheckUser(i, DocProcessId) == false)
                {
                    var user = _context.UserRights.Where(a => a.UserName1 == i).Select(a => a.FullName1).FirstOrDefault();
                    return Json("Văn bản này đã được chuyển đến cho " + user);
                }
                else
                {
                    DocFeedBack docFeedBack = new DocFeedBack();
                    docFeedBack.DocProcessId = long.Parse(DocProcessId);
                    docFeedBack.Idea = Idea;
                    docFeedBack.DateCreate = DateTime.Now;
                    docFeedBack.DateLimit = DateTime.Now.Date;
                    docFeedBack.UserSend = HttpContext.Session.GetString("UserName");
                    docFeedBack.UserReceive = i;
                    docFeedBack.StatusFeedBack = 0;
                    docFeedBack.DocFeedBackParentId = FeedbackId == 0 ? 0 : FeedbackId;
                    _context.DocFeedBacks.Add(docFeedBack);
                    _context.SaveChanges();
                    for(var j = 0;j < ListFileAttachFeedback.Count; j++)
                    {
                        FeedBackFileAttach feedBackFileAttach = new FeedBackFileAttach();
                        feedBackFileAttach.FeedBackId = _context.DocFeedBacks.Max(a => a.DocFeedBackId);
                        feedBackFileAttach.FileAttach = ListFileAttachFeedback[j].FileAttach;
                        feedBackFileAttach.FileSource = ListFileAttachFeedback[j].FileSource;
                        _context.FeedBackFileAttaches.Add(feedBackFileAttach);
                        _context.SaveChanges();

                    }
                    ListFileAttachFeedback.Clear();
                    
                }
            }
            return Json("Update success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDocFeedBack(string key)
        {
            var model = await _context.DocFeedBacks.FirstOrDefaultAsync(item =>
                            item.DocFeedBackId == long.Parse(key));
            _context.DocFeedBacks.Remove(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
        public Boolean CheckUser(string user,string DocProcessId)
        {
            if (_context.DocFeedBacks.Where(a => a.DocFeedBackId == long.Parse(DocProcessId)).Any(a => a.UserReceive == user))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        [HttpPost]
        public void Add_file_attach(IEnumerable<IFormFile> files)
        {
            ListFileAttachFeedback.Clear();
            foreach (var file in files)
            {
                string fileName = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\FeedbackFileAttach\\{file.FileName}";
                using (FileStream fileStream = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                string newFileName = AutoId.AutoIdFileStored("FileStored");
                string ext = Path.GetExtension(file.FileName);
                string newFile = $"{_env.ContentRootPath}\\wwwroot\\FileUploads\\FeedbackFileAttach\\{newFileName}{ext}";
                using (FileStream fileStream = System.IO.File.Create(newFile))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                ListFileAttachFeedback.Add(new FeedBackFileAttach { FileAttach = newFileName + ext, FileSource = file.FileName });
            }
        }
        [HttpPost]
        public IActionResult ViewFileDocument(string id)
        {
            var Document = _context.Documents.Where(a => a.DocId == long.Parse(id)).FirstOrDefault();
            var image = _context.DocFileAttaches.Where(a => a.DocId == long.Parse(id)).Select(a => a.FileAttach).ToList();
            ViewBag.countImage = image.Count;
            ViewBag.ListImage = image;
            return PartialView("_PartiView_ViewFileDocument");
        }
        public void SendFileToUser(string fileName,string DocId,string UserReceive)
        {
            Random random = new Random();
            var DocumentItem = _context.Documents.Where(a => a.DocId == long.Parse(DocId)).FirstOrDefault();
            Document document = new Document();
            document.DocStyleId = 2;
            document.Contents = "Ý kiến BTGĐ - " + DocumentItem.Contents;
            document.DateCreate = DateTime.Now;
            document.DepId = _context.UserRights.Where(a => a.UserName1 == HttpContext.Session.GetString("UserName")).Select(a => a.Department).FirstOrDefault();
            document.DocDate = DateTime.Now;
            document.DocLever = 0;
            document.DocPlaceId = 0;
            document.IsPublic = 0;
            document.DocTypeId = 12;
            document.Macn = HttpContext.Session.GetString("UnitName");
            document.Note = "";
            document.NumberCome = "";
            document.NumberOfPage = 1;
            document.Singer = "";
            document.NumberSign = random.Next(000000, 999999).ToString();
            document.UserCreate = HttpContext.Session.GetString("UserName");
            _context.Documents.Add(document);
            _context.SaveChanges();
            DocProcess docpro = new DocProcess()
            {
                UserSend = HttpContext.Session.GetString("UserName"),
                DocId = document.DocId,
                ObjectProcess = UserReceive,
                DateLimit = DateTime.Now,
                Command = "",
                StatusProcess = 1,
                DateReceive = DateTime.Now,
                NoteProcessReady = ""
            };
            _context.DocProcesses.Add(docpro);
            _context.SaveChanges();
            DocFileAttach docfile = new DocFileAttach()
            {
                DocId = document.DocId,
                FileSource = fileName,
                FileAttach = fileName
            };
            _context.DocFileAttaches.Add(docfile);
            _context.SaveChanges();
        }
        [HttpPost]
        public IActionResult EOffice(string fileName,string DocId)
        {
            SendFileToUser(fileName, DocId, "VT-INX");
            return Json("Chuyển văn thư thành công");
        }
        [HttpPost]
        public IActionResult Reply(string fileName,string DocId)
        {
            var UserSend = (from a in _context.Documents join b in _context.DocProcesses on a.DocId equals b.DocId where a.DocId == long.Parse(DocId) select b.UserSend).FirstOrDefault();
            SendFileToUser(fileName, DocId, UserSend);
            return Json("Chuyển văn thư thành công");
        }
        [HttpPost]
        public IActionResult SendToReceiver(string fileName, string DocId, string[] array)
        {
            foreach(string i in array)
            {
                SendFileToUser(fileName, DocId, i);
            }
            return Json("aaaaa");
        }
    }
}
