using Application.Parameter;
using Data.Models.Trading_system;
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SpreadsheetViewModel
    {

        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public static void SaveDocument(byte[] bytes)
        {
            tradingsystemContext context = new tradingsystemContext(ConnectionParameter.connectionString);
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
