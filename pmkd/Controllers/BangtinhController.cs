using DevExpress.AspNetCore.Spreadsheet;
using DevExpress.Spreadsheet;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class BangtinhController : Controller
    {
        public tradingsystem_blContext _context;
        private const string DocumentId2 = "MyDocument2";
        public BangtinhController(tradingsystem_blContext context)
        {
            _context = context;
        }
        public IActionResult bangtinh()
        {
            ViewBag.nhapkho = (from a in _context.NhapKhoKs
                               join b in _context.NhapKhoChiTietKs on a.Id equals b.NhapKhoId
                               select new { b.Rnw, b.DonGia, a.BangTinhId, b.RhopDong, b.Id, b.stt }).ToList().OrderBy(a => a.Id);
            ViewBag.bangtinh = (from a in _context.PobangTinhs select a).ToList();
            return View("bangtinh");
        }
        [HttpGet]
        public object getBangTinh(DataSourceLoadOptions loadOptions)
        {
            var item = _context.PobangTinhs.Select(i => new {
                i.Idbt,
                i.SoXe,
                i.NgayP,
            }).Distinct().ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }

        [HttpPost]
        [HttpGet]
        public IActionResult DxDocRequest()
        {
            return SpreadsheetRequestProcessor.GetResponse(HttpContext);
        }
        public IActionResult themBT()
        {
            ViewBag.can = (from c in _context.Cans
                           select new
                           {
                               c.SystemId,
                               c.LaiXe,
                               GW = c.TlNet + c.TlBao,
                               c.TlBao,
                               c.TlNet
                           }).ToList();
            ViewBag.xeptai = (from x in _context.XepTais
                              select new
                              {
                                  x.CanId,
                                  x.Id,
                                  x.SoXe,
                                  x.HopDong,
                                  x.NgayHd,
                                  x.MaKhach,
                                  x.KhachHang,
                                  x.Kcs,
                                  x.PhieuNhapKho,
                                  x.KhoName,
                                  x.Mahang,
                                  x.Tenhang,
                                  x.SoBao,
                                  Dvt = "kgs",
                              }).ToList();
            string DocumentId1 = "MyDocumentId1";
            var ByteArray = (from a in _context.PobangTinhs where ((a.Idbt == "BT1600000001") && (a.Iddong == 1)) select a.docs).FirstOrDefault();
            byte[] byteArrayAccessor() => ByteArray;
            var model = new SpreadsheetViewModel(DocumentId1, byteArrayAccessor);
            return View("ThemBT", model);
        }
        [HttpPost]
        public IActionResult updatespreadsheet(string spreadsheetStateID,string id)
        {
            string str = spreadsheetStateID;
            SpreadsheetClientState st = new SpreadsheetClientState();
            st.SpreadsheetWorkSessionId = str;
            var spreadsheet = SpreadsheetRequestProcessor.GetSpreadsheetFromState(st);
            Workbook workbook = new Workbook();
            MemoryStream stream = new MemoryStream();
            spreadsheet.SaveCopy(stream, DocumentFormat.Xlsx);
            stream.Position = 0;
            workbook.LoadDocument(stream);
            Worksheet sht = workbook.Worksheets[0];
            sht[0, 0].Value = id;
            byte[] docBytes = workbook.SaveDocument(DocumentFormat.Xlsx);
            Func<byte[]> contentAccessor = () => docBytes;
            var model = new SpreadsheetViewModel(DocumentId2, contentAccessor);
            return PartialView("SpreadsheetBT", model);
        }
        public void SaveToBytes(SpreadsheetClientState spreadsheetState)
        {
            var spreadsheet = SpreadsheetRequestProcessor.GetSpreadsheetFromState(spreadsheetState);
            string documentId = spreadsheet.DocumentId;
            byte[] documentContent = spreadsheet.SaveCopy(DocumentFormat.Xlsx);
            SpreadsheetViewModel.SaveDocument(documentContent);
        }
        public IActionResult Download(SpreadsheetClientState spreadsheetState)
        {
            const string XlsxContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var spreadsheet = SpreadsheetRequestProcessor.GetSpreadsheetFromState(spreadsheetState);
            MemoryStream stream = new MemoryStream();
            spreadsheet.SaveCopy(stream, DocumentFormat.Xlsx);
            stream.Position = 0;
            return File(stream, XlsxContentType, "bangtinh.xlsx");

        }
    }
}
