using Application.Parameter;
using Data.Models.Trading_system;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Eoffice
{
    public class DocDetail
    {
        public static bool CheckUserViewImage(long DocId,string UserName)
        {
            tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
            var Sp = "exec sp_Document;31 " +
                        "@DocId = '" + DocId + "'," +
                        "@UserName = '" + UserName + "'";
            var item = _context.Documents.FromSqlRaw(Sp).ToList();
            if (item == null || item.Count == 0)
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
