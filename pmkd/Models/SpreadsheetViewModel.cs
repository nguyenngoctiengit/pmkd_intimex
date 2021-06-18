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
        public tradingsystem_blContext _context;
        public tradingsystem_blContext db = new tradingsystem_blContext();
        public SpreadsheetViewModel(tradingsystem_blContext context)
        {
            _context = context;
        }
/*        public static byte[] GetDocument()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=tradingsystem_bl;Integrated Security=True;Connect Timeout=30");
            string query = "select docs from POBangTinh where IDBT = 'BT1600000001' and IDDong = '1'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
            return (byte[])dataTable.Rows[0]["docs"];
        }*/
        public static byte[] GetDocument()
        {
            tradingsystem_blContext context = new tradingsystem_blContext();
            return context.PobangTinhs.Where(a => a.Idbt == "BT1600000001").Select(a => a.docs).FirstOrDefault().ToArray();
        }
        public static void SaveDocument(byte[] bytes)
        {
            tradingsystem_blContext context = new tradingsystem_blContext();
            context.PobangTinhs.FirstOrDefault().docs = bytes;
            context.SaveChanges();
        }
        public class SpreadsheetData
        {
            public string DocumentId { get; set; }
            public DocumentFormat DocumentFormat { get; set; }
            public byte[] Document { get; set; }
            public Func<byte[]> ContentAccessorByBytes
            {
                get { return () => { return Document; }; }
            }
        }
    }
}
