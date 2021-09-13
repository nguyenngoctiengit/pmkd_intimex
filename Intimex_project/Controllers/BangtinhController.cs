using Application.Parameter;
using DevExpress.AspNetCore.Spreadsheet;
using DevExpress.Spreadsheet;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.Trading_system;
using ViewModel;
using Data.Models.SignalR;

namespace Intimex_project.Controllers
{
    public class BangtinhController : Controller
    {
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        private const string DocumentId2 = "MyDocument2";
        public BangtinhController()
        {
        }
        public void listUser()
        {
            using (SignalRChatContext _context = new SignalRChatContext())
            {
                ViewBag.ListUser = (from a in _context.AspNetUsers select new Data.Models.SignalR.AspNetUser { NormalizedUserName = a.NormalizedUserName, Online = a.Online, Id = a.Id }).OrderByDescending(a => a.Online).ToList();
            }
                
        }
        public IActionResult bangtinh()
        {
            listUser();
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
            }).Where(a => a.Idbt == "BT1600000001").Distinct().ToList();
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
            listUser();
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
        public IActionResult updatespreadsheet(string spreadsheetStateID, string id)
        {
            listUser();
            var item_return = (from a in _context.Kcs where a.SoPhieu == id select a).FirstOrDefault();
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
            sht[1, 2].Value = item_return.DoAm; sht[2, 2].Value = item_return.TapChat; sht[3, 2].Value = item_return.DenVo;
            sht[6, 2].Value = item_return.HatCxk; sht[5, 2].Value = item_return.HatNau; sht[4, 2].Value = item_return.HatMoc;
            sht[7, 2].Value = item_return.TrangXop; sht[8, 2].Value = item_return.HatChay; sht[9, 2].Value = item_return.HatKhac;
            sht[12, 2].Value = item_return.Sang13; sht[11, 2].Value = item_return.Sang12; sht[10, 2].Value = item_return.Sang8;
            sht[13, 2].Value = item_return.Sang14; sht[14, 2].Value = item_return.Sang15; sht[15, 2].Value = item_return.Sang16;
            sht[18, 2].Value = item_return.Sang19; sht[17, 2].Value = item_return.Sang18; sht[16, 2].Value = item_return.Sang17;
            sht[19, 2].Value = item_return.Sang20;
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
