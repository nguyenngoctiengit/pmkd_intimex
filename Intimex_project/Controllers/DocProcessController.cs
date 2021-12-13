using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class DocProcessController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
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
                        "@DateTo = '"+ DateTime.Now.ToString("yyyy/MM/dd") +"',"+
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
                if (CheckUser(i, DocProcessId))
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



    }
}
