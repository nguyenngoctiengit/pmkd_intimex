using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Models
{
    public class SpreadsheetViewModel 
    {
        public tradingsystem_blContext _context = new tradingsystem_blContext("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;pooling=false;Timeout=60;Integrated Security=SSPI;MultipleActiveResultSets=true");
        public static void SaveDocument(byte[] bytes)
        {
            tradingsystem_blContext context = new tradingsystem_blContext("Server=DESKTOP-MO33L1P\\SQLEXPRESS;Database=tradingsystem_bl;Trusted_Connection=True;pooling=false;Timeout=60;Integrated Security=SSPI;MultipleActiveResultSets=true");
            context.PobangTinhs.FirstOrDefault().docs = bytes;
            context.SaveChanges();
        }
        public string DocumentId { get; set; }
        public Func<byte[]> ContentAccessorByBytes { get; set; }
        public DocumentFormat DocumentFormat { get; set; } = DocumentFormat.Xlsx;

        public SpreadsheetViewModel(string documentId, Func<byte[]> contentAccessorByBytes)
        {
            DocumentId = documentId;
            ContentAccessorByBytes = contentAccessorByBytes;
        }
    }
}
