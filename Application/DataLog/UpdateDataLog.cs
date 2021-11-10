using Application.Parameter;
using Data.Models.Trading_system;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataLog
{
    public class UpdateDataLog
    {
        public static void DataLog(string TableName,string KeyId,DateTime EditDate,string Columns,string OldValue,string NewValue,string EditPerson,int TypeAction,string Macn)
        {
            tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
            EditDataLog dataLog = new EditDataLog();
            dataLog.TableName = TableName;
            dataLog.KeyId = KeyId;
            dataLog.EditDate = EditDate;
            dataLog.Columns = Columns;
            dataLog.OldValue = OldValue;
            dataLog.NewValue = NewValue;
            dataLog.EditPerson = EditPerson;
            dataLog.TypeAction = TypeAction;
            dataLog.Macn = Macn;
            _context.EditDataLogs.Add(dataLog);
            _context.SaveChanges();
        }
        public static string DisplayStates(tradingsystemContext context)
        {
            foreach(EntityEntry entry in context.ChangeTracker.Entries())
            {
                return entry.State.ToString();
            }
            return null;
        }
    }
    
}
