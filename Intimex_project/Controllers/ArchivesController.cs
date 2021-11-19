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
    public class ArchivesController : Controller
    {
        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public IActionResult Archives()
        {
            return View("Archives");
        }

        public int CountJobLimitDate(string username, long ArchiveId)
        {
            var count = 0;
            count = (from a in _context.ArchivesAssignTasks
                     join b in _context.Archives
                     on a.ArchivesId equals b.ArchivesId
                     where a.ArchivesId == ArchiveId &&
                    a.UserAccept == username || a.UserAssign == username && a.IsFinish == 0 &&
                    (DateTime.Now - a.DateAssign).Days <= 0 && a.ArchivesId == 0 || a.ArchivesId == ArchiveId
                     select a.ArchivesId).Count();
            return count;
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec GetArchives " +
                            "@macn = " + "INX" + "," +
                            "@user = '" + "CHIEN" + "'";
            var item = _context.SP_GetArchives.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }

    }

}
