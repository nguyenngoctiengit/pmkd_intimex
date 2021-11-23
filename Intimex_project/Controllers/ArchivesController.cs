using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class ArchivesController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
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
            var item = _context.ArchivesAssignTasks.Where(a => a.ArchivesId == id).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
    }

}
