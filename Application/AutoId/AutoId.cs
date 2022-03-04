using Application.Parameter;
using Data.Models.Trading_system;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoId
{
    public class AutoId 
    {
        public static string AutoIdFileStored(string tableName)
        {
            tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
            var PrefixOfDefaultValueForId = _context.AutomaticValues.Where(a => a.ObjectName == tableName).Select(a => a.PrefixOfDefaultValueForId).FirstOrDefault();
            var LengthOfDefaultValueForId = (int)_context.AutomaticValues.Where(b => b.ObjectName == tableName).Select(b => b.LengthOfDefaultValueForId).FirstOrDefault();
            var LastValueOfColumnId = _context.AutomaticValues.Where(c => c.ObjectName == tableName).Select(c => c.LastValueOfColumnId).FirstOrDefault();
            var oldValue = Convert.ToInt32(LastValueOfColumnId.Substring(PrefixOfDefaultValueForId.Length + 1, LengthOfDefaultValueForId - 2)); 
            var chuoi = "0000000000000000000000000000000" + Convert.ToInt32(oldValue + 1);
            var ParamateOut = PrefixOfDefaultValueForId + chuoi.Substring(chuoi.Length + 1 - LengthOfDefaultValueForId, LengthOfDefaultValueForId - 1);
            var AutomaticValues = _context.AutomaticValues.Where(a => a.ObjectName == tableName).FirstOrDefault();
            AutomaticValues.LastValueOfColumnId = ParamateOut;
            _context.AutomaticValues.Update(AutomaticValues);
            _context.SaveChanges();
            return ParamateOut;
        }
        public static string AutoIdHangHoa(string tableName)
        {
            tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
            var PrefixOfDefaultValueForId = _context.AutomaticValues.Where(a => a.ObjectName == tableName).Select(a => a.PrefixOfDefaultValueForId).FirstOrDefault();
            var LengthOfDefaultValueForId = (int)_context.AutomaticValues.Where(b => b.ObjectName == tableName).Select(b => b.LengthOfDefaultValueForId).FirstOrDefault();
            var LastValueOfColumnId = _context.AutomaticValues.Where(c => c.ObjectName == tableName).Select(c => c.LastValueOfColumnId).FirstOrDefault();
            var oldValue = Convert.ToInt16(LastValueOfColumnId.Substring(PrefixOfDefaultValueForId.Length));
            var chuoi = "0000000000000000000000000000000" + Convert.ToInt16(oldValue + 1);
            var ParamateOut = PrefixOfDefaultValueForId + chuoi.Substring(chuoi.Length + 1 - LengthOfDefaultValueForId);
            var AutomaticValues = _context.AutomaticValues.Where(a => a.ObjectName == tableName).FirstOrDefault();
            AutomaticValues.LastValueOfColumnId = ParamateOut;
            _context.AutomaticValues.Update(AutomaticValues);
            _context.SaveChanges();
            return ParamateOut;
        }
    }
}
