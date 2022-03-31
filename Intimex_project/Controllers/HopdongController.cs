using Application.AutoId;
using Application.Parameter;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Intimex_project.Controllers
{
    public class HopdongController : Controller
    {
        decimal tongCong_TablePrice = 0;
        IWebHostEnvironment _hostingEnvironment;
        public DateTime NgayKy;
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public HopdongController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        //Index
        public IActionResult Index()
        {
            return View();
        }   
        [HttpGet]
        public object GetTienTe(DataSourceLoadOptions options)
        {
            var item_money = from a in _context.Money
                             select new
                             {
                                 Ma = a.Ma,
                                 Ten = a.Ten
                             };
            return DataSourceLoader.Load(item_money, options);
        }
        //View HDMB
        [HttpGet]
        public object GetHopdong(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Hdmbs
                        select new
                        {
                            a.Systemref,
                            a.Ngaylam,
                            a.Sohd,
                            Trangthai = a.Trangthai == 2 ? "Hủy" : a.Trangthai == 1 ? "TH" : "TL",
                            a.MuaBan
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetCt_HDMB(string id, DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.CtHdmbs
                        join b in _context.Hanghoas on a.Mahang equals b.Mahang
                        where a.Systemref == id
                        select new
                        {
                            a.IdRow,
                            a.Systemref,
                            a.Mahang,
                            Tenhang = b.Tenhang,
                            a.Soluong,
                            a.Trongluong,
                            a.Dvt,
                            a.Vat,
                            a.Giact,
                            a.Giatt,
                            a.Solot,
                            a.Giathang,
                            a.Gianam,
                            a.Sig,
                            a.Diff,
                            a.FNgayfix,
                            a.Stoploss,
                            MaNhom = b.MaNhom,
                            a.Giathitruong,
                            a.Mucthuong
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public IActionResult hdmb()
        {
            ViewBag.macn = HttpContext.Session.GetString("UnitName");
            return View("hdmb");
        }
        [HttpPost]
        public IActionResult Fill_Form_HDMB(string Systemref)
        {
            var Name_IntKy = "";
            var IntKy = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.IntKy).FirstOrDefault().Trim();
            var Name_ClientKy = "";
            if (IntKy == null || IntKy == "")
            {
                Name_IntKy = "";
            }
            else
            {
                Name_IntKy = (from a in _context.Signers where a.MaKhach == IntKy.Substring(0, IntKy.Length - 1) && a.Stt == int.Parse(IntKy.Substring(IntKy.Length - 1)) select a.Nguoiky).FirstOrDefault().Trim() + " chức vụ " + (from a in _context.Signers where a.MaKhach == IntKy.Substring(0, IntKy.Length - 1) && a.Stt == int.Parse(IntKy.Substring(IntKy.Length - 1)) select a.Chucvu).FirstOrDefault();
            }
            if (_context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.ClientKy).FirstOrDefault().Trim() == "")
            {
                Name_ClientKy = "";
            }
            else
            {
                var Client_Ky = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.ClientKy).FirstOrDefault().Trim();
                Name_ClientKy = (from a in _context.Signers where a.MaKhach == Client_Ky.Substring(0, Client_Ky.Length - 1) && a.Stt == int.Parse(Client_Ky.Substring(Client_Ky.Length - 1)) select a.Nguoiky).FirstOrDefault().Trim() + " chức vụ " + (from a in _context.Signers where a.MaKhach == Client_Ky.Substring(0, Client_Ky.Length - 1) && a.Stt == int.Parse(Client_Ky.Substring(Client_Ky.Length - 1)) select a.Chucvu).FirstOrDefault();
            }
            var data = (from a in _context.Hdmbs
                        where a.Systemref == Systemref
                        select new
                        {
                            Systemref = a.Systemref,
                            Ref = a.Ref,
                            Makhach = a.Makhach,
                            Sohd = a.Sohd,
                            Tiente = a.Tiente,
                            IntKy = a.IntKy,
                            ClientKy = a.ClientKy,
                            Thanhtoan = a.Thanhtoan,
                            Tenfull = a.Tenfull,
                            DiaDiemGiaoHang = a.DiaDiemGiaoHang,
                            Ghichu = a.Ghichu,
                            Ngayky = a.Ngayky,
                            Ngaygiao = a.Ngaygiao,
                            Ngayhl = a.Ngayhl,
                            NgayTraPhaitra = a.NgayTraPhaitra,
                            TienUngHd = Convert.ToDecimal(a.TienUngHd),
                            TienUngTt = a.TienUngTt,
                            Nguoilam = a.Nguoilam,
                            Ngaylam = a.Ngaylam,
                            Macn = a.Macn,
                            VanChuyen = a.VanChuyen,
                            HdcmuonId = a.HdcmuonId,
                            SoHdcmuon = a.SoHdcmuon,
                            Money = _context.Money.Where(m => m.Ma == a.Tiente).Select(m => m.Ten).FirstOrDefault(),
                            TenTT = _context.PortfolioPayments.Where(m => m.Id == a.ThanhtoanId).Select(a => a.TenTt).FirstOrDefault(),
                            Mucung = _context.PortfolioPayments.Where(m => m.Id == a.ThanhtoanId).Select(a => a.Mucung).FirstOrDefault() + "%",
                            Name_IntKy = Name_IntKy,
                            Name_ClientKy = Name_ClientKy,
                            MuaBan = a.MuaBan,
                            IsFix = a.IsFix,
                            TypeKd = a.TypeKd,
                            Pakd = a.Pakd,
                            IsNoKhoDoi = a.IsNoKhoDoi,
                        }).FirstOrDefault();
            return Json(data);
        }
        [HttpPost]
        public JsonResult GetList_Annex(string Systemref)
        {
            var MaHang_CtHDMB = _context.CtHdmbs.Where(a => a.Systemref == Systemref).Select(a => a.Mahang).FirstOrDefault();
            var MaNhom_Hanghoa = _context.Hanghoas.Where(a => a.Mahang == MaHang_CtHDMB).Select(a => a.MaNhom).FirstOrDefault();
            var listAnnex = _context.Annices.Where(a => a.MaNhom == MaNhom_Hanghoa).Select(a => a.NoiDung).ToList();
            return Json(listAnnex);
        }
        [HttpPost]
        public IActionResult Fill_Form_CTHD(string IdRow)
        {
            var data = (from a in _context.CtHdmbs
                        where a.IdRow == IdRow
                        select new
                        {
                            a.GiaTheoHd,
                            a.IdRow,
                            a.Systemref,
                            a.Ref,
                            a.Soluong,
                            a.Trongluong,
                            a.Mahang,
                            a.Dvt,
                            a.Giact,
                            a.Giatt,
                            a.Vat,
                            a.Sig,
                            a.Diff,
                            a.Stoploss,
                            a.Giacuoi,
                            a.Solot,
                            a.FNgayfix,
                            a.Giathang,
                            a.Gianam,
                            a.DvtTheoHd,
                            a.Mucthuong,
                            a.ChuyenThang,
                            a.Giathitruong,
                            SoHD = _context.Hdmbs.Where(b => b.Systemref == a.Systemref).Select(a => a.Sohd).FirstOrDefault(),
                            TenhangHoa = _context.Hanghoas.Where(b => b.Mahang == a.Mahang).Select(a => a.Tenhang).FirstOrDefault()
                        }).FirstOrDefault();
            return Json(data);
        }
        [HttpGet]
        public object GetKH(DataSourceLoadOptions loadOptions)
        {
            var khachhang = (from a in _context.KhachHangs
                             where a.GiaoDich == 1
                             select new
                             {
                                 a.MaKhach,
                                 a.TenKhach,
                                 checkitem = _context.CustomerNorms.Where(m => m.Makhach == a.MaKhach && m.Macn == a.MaCn).Select(a => a.ValueNorm).Count() > 0 ? 1 : 0,
                                 ValueNorm = _context.CustomerNorms.Where(m => m.Makhach == a.MaKhach && m.Macn == a.MaCn).Select(a => a.ValueNorm).FirstOrDefault(),
                                 a.Vanchuyen,
                                 a.MaHd
                             }).ToList();
            return DataSourceLoader.Load(khachhang, loadOptions);
        }
        [HttpPost]
        public IActionResult AddHopDong(string id, Hdmb hdmb)
        {
            if (id == "" || id == null)
            {
                Hdmb item = new Hdmb();
                var datetime = DateTime.Now;
                if (_context.Hdmbs.Any(a => a.Ref == hdmb.Ref + "/" + datetime.ToString("yy")))
                {
                    TempData["alertMessage"] = "Số Ref này đã tồn tại!";
                    return RedirectToAction("hdmb");
                }
                else if (hdmb.Ngaygiao.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngaygiao.Value.Date)
                {
                    TempData["alertMessage"] = "Chọn ngày Hợp đồng, ngày giao hàng, ngày hiệu lực chưa đúng!\n Ngày hợp đồng <= ngày giao hàng <= ngày hiệu lực";
                    return RedirectToAction("hdmb");
                }
                else
                {
                    item.TienUngHd = hdmb.TienUngHd;
                    item.TienUngTt = hdmb.TienUngTt;
                    item.Tenfull = hdmb.Tenfull;
                    item.Ngaylam = DateTime.Now;
                    item.Macn = HttpContext.Session.GetString("UnitName");
                    item.Systemref = AutoId.AutoIdFileStored("hdmb");
                    item.Ref = hdmb.Ref.Trim() + "/" + hdmb.Ngayky.Value.ToString("yy");
                    item.Sohd = hdmb.Sohd.Trim();
                    item.Trangthai = 1;
                    item.MuaBan = hdmb.MuaBan;
                    item.Makhach = hdmb.Makhach;
                    item.Ngayky = hdmb.Ngayky;
                    item.Ngaygiao = hdmb.Ngaygiao;
                    item.Ngayhl = hdmb.Ngayhl;
                    item.Nguoilam = HttpContext.Session.GetString("UserName");
                    item.Ghichu = hdmb.Ghichu;
                    item.Pakd = hdmb.Pakd;
                    item.Thanhtoan = hdmb.Thanhtoan;
                    item.IntKy = hdmb.IntKy == null ? "" : hdmb.IntKy;
                    item.ClientKy = hdmb.ClientKy == null ? "" : hdmb.ClientKy;
                    item.Docstatus = false;
                    item.Tiente = hdmb.Tiente;
                    item.IsFix = hdmb.IsFix;
                    item.NgayTraPhaitra = hdmb.NgayTraPhaitra == null ? DateTime.Now : hdmb.NgayTraPhaitra;
                    item.SoHdcmuon = hdmb.SoHdcmuon == null ? "" : hdmb.SoHdcmuon;
                    item.HdcmuonId = hdmb.HdcmuonId == null ? "" : hdmb.HdcmuonId;
                    item.DiaDiemGiaoHang = hdmb.DiaDiemGiaoHang;
                    item.ThanhtoanId = _context.PortfolioPayments.Where(a => a.Matt == hdmb.Thanhtoan).Select(a => a.Id).FirstOrDefault();
                    item.IsNoKhoDoi = hdmb.IsNoKhoDoi;
                    item.TypeKd = hdmb.TypeKd;
                    item.VanChuyen = hdmb.VanChuyen;
                    _context.Hdmbs.Add(item);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Thêm hợp đồng thành công";
                    return RedirectToAction("hdmb");

                }
            }
            else
            {
                Hdmb item = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
                var datetime = DateTime.Now;
                if (_context.Hdmbs.Any(a => a.Ref == hdmb.Ref + "/" + datetime.ToString("yy")))
                {
                    TempData["alertMessage"] = "Số Ref này đã tồn tại!";
                    return RedirectToAction("hdmb");
                }
                else if (hdmb.Ngaygiao.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngaygiao.Value.Date)
                {
                    TempData["alertMessage"] = "Chọn ngày Hợp đồng, ngày giao hàng, ngày hiệu lực chưa đúng!\n Ngày hợp đồng <= ngày giao hàng <= ngày hiệu lực";
                    return RedirectToAction("hdmb");
                }
                else
                {
                    item.TienUngHd = hdmb.TienUngHd;
                    item.TienUngTt = hdmb.TienUngTt;
                    item.Tenfull = hdmb.Tenfull;
                    item.Ref = hdmb.Ref.Trim() + "/" + hdmb.Ngayky.Value.ToString("yy");
                    item.Sohd = hdmb.Sohd.Trim();
                    item.Trangthai = 1;
                    item.MuaBan = hdmb.MuaBan;
                    item.Makhach = hdmb.Makhach;
                    item.Ngayky = hdmb.Ngayky;
                    item.Ngaygiao = hdmb.Ngaygiao;
                    item.Ngayhl = hdmb.Ngayhl;
                    item.Ghichu = hdmb.Ghichu;
                    item.Pakd = hdmb.Pakd;
                    item.Thanhtoan = hdmb.Thanhtoan;
                    item.IntKy = hdmb.IntKy;
                    item.ClientKy = hdmb.ClientKy;
                    item.Docstatus = false;
                    item.Tiente = hdmb.Tiente;
                    item.IsFix = hdmb.IsFix;
                    item.NgayTraPhaitra = hdmb.NgayTraPhaitra;
                    item.SoHdcmuon = hdmb.SoHdcmuon == null ? "" : hdmb.SoHdcmuon;
                    item.HdcmuonId = hdmb.HdcmuonId == null ? "" : hdmb.HdcmuonId;
                    item.DiaDiemGiaoHang = hdmb.DiaDiemGiaoHang;
                    item.ThanhtoanId = _context.PortfolioPayments.Where(a => a.Matt == hdmb.Thanhtoan).Select(a => a.Id).FirstOrDefault();
                    item.IsNoKhoDoi = hdmb.IsNoKhoDoi;
                    item.TypeKd = hdmb.TypeKd;
                    item.VanChuyen = hdmb.VanChuyen;
                    _context.Hdmbs.Update(item);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Chỉnh sửa hợp đồng thành công";
                    return RedirectToAction("hdmb");

                }
            }


        }
        [HttpGet]
        public object getIntKy(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Signers
                        where a.MaKhach == HttpContext.Session.GetString("UnitName")
                        select new
                        {
                            Makhach = a.MaKhach + a.Stt,
                            Nguoiky = a.Nguoiky.Trim() + " chức vụ " + a.Chucvu,
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }

        [HttpGet]
        public object getClientKy(string id, DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Signers
                        where a.MaKhach == id
                        select new
                        {
                            Makhach = a.MaKhach + a.Stt,
                            Nguoiky = a.Nguoiky.Trim() + " chức vụ " + a.Chucvu,
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object getThanhToan(string id, DataSourceLoadOptions loadOptions)
        {
            var muaban = id.Substring(0, 3);
            var isfix = id.Substring(3);
            var hinhthucgia = 0;
            if (isfix == "true")
            {
                hinhthucgia = 1;
            }
            else
            {
                hinhthucgia = 0;
            }
            var item = (from a in _context.PortfolioPayments
                        where a.LoaiHd == muaban && a.HinhThucGia == hinhthucgia
                        select new
                        {
                            a.Matt,
                            a.TenTt,
                            a.Mucung,
                            a.ReportName,
                            a.Id
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object getHDCmuon(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Hdmbs
                        where a.Macn == HttpContext.Session.GetString("UnitName") && a.MuaBan == "CMUON" && a.Trangthai != 2
                        select new
                        {
                            a.Systemref,
                            a.Ref,
                            a.Sohd,
                            a.Makhach,
                            a.Ngayky,
                            a.Ngaygiao,
                            a.Ghichu
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetHangHoa(string id, DataSourceLoadOptions loadOptions)
        {
            var Sp = "exec [Sp_hanghoa];6 @mahang = ''," +
                        "@makhach = '" + id + "'," +
                        "@macn = '" + HttpContext.Session.GetString("UnitName") + "'";
            var item = _context.Sp_GetHangHoa_CtHDmbs.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetAnnex_HDMB(string id, DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.HdmbAnnices
                        where a.Systemref == id
                        select new
                        {
                            a.Id,
                            a.Number,
                            a.NoiDung,
                            a.NgayTao,
                            a.Path,
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public IActionResult CancelContract(string id)
        {
            var item = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            if (_context.InputStocks.Any(a => a.ContractId == item.Systemref && a.StatusDestroy == false) || _context.OutputStocks.Any(a => a.ContractId == item.Systemref && a.StatusDestroy == false))
            {
                TempData["alertMessage"] = "Hợp đồng đã giao hàng không hủy được";
                return RedirectToAction("hdmb");
            }
            else
            if (_context.Fixgia.Any(a => a.Systemref == item.Systemref))
            {
                TempData["alertMessage"] = "Hợp đồng đã fix giá không hủy được";
                return RedirectToAction("hdmb");
            }
            else
            {
                item.Trangthai = 2;
                item.Ngaytl = DateTime.Now;
                item.Nguoilam = HttpContext.Session.GetString("UserName");
                _context.Hdmbs.Update(item);
                _context.SaveChanges();
                TempData["alertMessage"] = "Hủy hợp đồng thành công";
                return RedirectToAction("hdmb");
            }

        }
        [HttpPost]
        public IActionResult Add_CTHD_OutRight(string id, string MaHang_CTHD_OutRight, string DVT_CTHD_OutRight, int VAT_CTHD_OutRight,
            int SoLuong_CTHD_OutRight, int TrongLuong_CTHD_OutRight, decimal OutRight_TheoHD_CTHD_OutRight, int OutRight_CTHD_OutRight, int GiaThiTruong_CTHD_OutRight, int MucThuong_CTHD_OutRight)
        {
            CtHdmb ctHdmb = new CtHdmb();
            ctHdmb.IdRow = AutoId.AutoIdFileStored("ct_hdmb");
            ctHdmb.Systemref = id;
            ctHdmb.Ref = _context.Hdmbs.Where(a => a.Systemref == id).Select(a => a.Ref).FirstOrDefault().Trim();
            ctHdmb.Soluong = SoLuong_CTHD_OutRight;
            ctHdmb.Giatt = 0;
            ctHdmb.Giathang = "";
            ctHdmb.Gianam = ""; 
            ctHdmb.Sig = "";
            ctHdmb.Diff = 0;
            ctHdmb.Stoploss = 0;
            ctHdmb.Solot = 0;
            ctHdmb.FNgayfix = new DateTime(1900, 01, 01);
            ctHdmb.Status = false;
            ctHdmb.Trongluong = TrongLuong_CTHD_OutRight;
            ctHdmb.Mahang = MaHang_CTHD_OutRight;
            ctHdmb.Dvt = "KGS";
            ctHdmb.Giact = OutRight_CTHD_OutRight;
            ctHdmb.Vat = VAT_CTHD_OutRight;
            ctHdmb.DvtTheoHd = DVT_CTHD_OutRight;
            ctHdmb.Giathitruong = GiaThiTruong_CTHD_OutRight;
            ctHdmb.Mucthuong = MucThuong_CTHD_OutRight;
            ctHdmb.GiaTheoHd = OutRight_TheoHD_CTHD_OutRight;
            _context.Entry(ctHdmb).State = EntityState.Added;
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "Thêm chi tiết hợp đồng OutRight thành công";
            return RedirectToAction("hdmb");
        }
        [HttpPost]
        public IActionResult Edit_CTHD_OutRight(string id, string SystemId_CTHD_OutRight_hidden, string MaHang_CTHD_OutRight, string DVT_CTHD_OutRight, int VAT_CTHD_OutRight,
            int SoLuong_CTHD_OutRight, int TrongLuong_CTHD_OutRight, decimal OutRight_TheoHD_CTHD_OutRight, int OutRight_CTHD_OutRight, int GiaThiTruong_CTHD_OutRight, int MucThuong_CTHD_OutRight)
        {
            var Sp = "exec [UdscCt_hdmb];2 @idrow = '" + id + "',@systemref = '" + SystemId_CTHD_OutRight_hidden + "'," +
                                                "@ref = '" + _context.Hdmbs.Where(a => a.Systemref == SystemId_CTHD_OutRight_hidden).Select(a => a.Ref).FirstOrDefault().Trim() + "'," +
                                                "@soluong = '" + SoLuong_CTHD_OutRight + "'," +
                                                "@trongluong = '" + TrongLuong_CTHD_OutRight + "'," +
                                                "@mahang = '" + MaHang_CTHD_OutRight + "'," +
                                                "@dvt = '" + "KGS" + "'," +
                                                "@giact = '" + OutRight_CTHD_OutRight + "'," +
                                                "@giatt = '" + 0 + "'," +
                                                "@vat = '" + VAT_CTHD_OutRight + "'," +
                                                "@giathang = '" + "" + "'," +
                                                "@gianam = '" + "" + "'," +
                                                "@sig = '" + "" + "'," +
                                                "@diff = '" + 0 + "'," +
                                                "@stoploss = '" + 0 + "'," +
                                                "@solot = '" + 0 + "'," +
                                                "@status = '" + false + "'," +
                                                "@f_ngayfix = '" + new DateTime(1900, 01, 01) + "'," +
                                                "@DVTTheoHD = '" + DVT_CTHD_OutRight + "'," +
                                                "@GiaTheoHD = '" + OutRight_TheoHD_CTHD_OutRight + "'," +
                                                "@GiaThiTruong = '" + GiaThiTruong_CTHD_OutRight + "'," +
                                                "@MucThuong = '" + MucThuong_CTHD_OutRight + "'";
            _context.Database.ExecuteSqlRaw(Sp);
            TempData["alertMessage"] = "Cập nhật chi tiết hợp đồng OutRight thành công";
            return RedirectToAction("hdmb");
        }
        [HttpPost]
        public IActionResult Add_CTHD(string id,string MaHang_CTHD, string DVT_CTHD, decimal GiaTT_CTHD, int SoLuong_CTHD, int ThueVAT_CTHD
            , int TrongLuong_CTHD, string Sig_CTHD, decimal SoLot_CTHD, decimal Muctru_CTHD, string GiaThang_CTHD, string NgayChot_CTHD
            , string GiaNam_CTHD, string MucStopLoss_CTHD, decimal GiaThiTruong_CTHD, decimal MucThuong_CTHD,int ChuyenThang_CTHD)
        {
            int t = 0;
            DateTime ngayky = (DateTime) _context.Hdmbs.Where(a => a.Systemref == id).Select(a => a.Ngayky).FirstOrDefault();
            if (int.TryParse(MucStopLoss_CTHD, out t) == false && t < 0)
            {
                TempData["alertMessage"] = "Stoploss nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            if (GiaThang_CTHD != "1" && GiaThang_CTHD != "3" && GiaThang_CTHD != "5" && GiaThang_CTHD != "7"
                && GiaThang_CTHD != "9" && GiaThang_CTHD != "11" && GiaThang_CTHD != "12")
            {
                TempData["alertMessage"] = "Giá tháng nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            if (int.TryParse(GiaNam_CTHD, out t) == false && t < ngayky.Year)
            {
                TempData["alertMessage"] = "Giá năm nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            if (DateTime.Parse(NgayChot_CTHD).Year > t || (DateTime.Parse(NgayChot_CTHD).Month > int.Parse(GiaThang_CTHD) && DateTime.Parse(NgayChot_CTHD).Year == t))
            {
                TempData["alertMessage"] = "Ngày chốt cuối nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            CtHdmb ctHdmb = new CtHdmb();
            ctHdmb.IdRow = AutoId.AutoIdFileStored("ct_hdmb");
            ctHdmb.Systemref = id;
            ctHdmb.Ref = _context.Hdmbs.Where(a => a.Systemref == id).Select(a => a.Ref).FirstOrDefault();
            ctHdmb.Soluong = SoLuong_CTHD;
            ctHdmb.Trongluong = TrongLuong_CTHD;
            ctHdmb.Mahang = MaHang_CTHD;
            ctHdmb.Dvt = DVT_CTHD;
            ctHdmb.Giact = 0;
            ctHdmb.Giatt = GiaTT_CTHD;
            ctHdmb.Vat = ThueVAT_CTHD;
            ctHdmb.Giathang = GiaThang_CTHD;
            ctHdmb.Gianam = GiaNam_CTHD;
            ctHdmb.Sig = Sig_CTHD;
            ctHdmb.Diff = Muctru_CTHD;
            ctHdmb.Stoploss = decimal.Parse(MucStopLoss_CTHD);
            ctHdmb.Solot = SoLot_CTHD;
            ctHdmb.Status = false;
            ctHdmb.FNgayfix = DateTime.Parse(NgayChot_CTHD);
            ctHdmb.DvtTheoHd = DVT_CTHD;
            ctHdmb.GiaTheoHd = 0;
            ctHdmb.Giathitruong = GiaThiTruong_CTHD;
            ctHdmb.Mucthuong = MucThuong_CTHD;
            ctHdmb.ChuyenThang = ChuyenThang_CTHD == 1 ? true : false;
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            TempData["alertMessage"] = "Thêm chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
        [HttpPost]
        public IActionResult Edit_CTHD(string id,string SystemId_CTHD_hidden, string MaHang_CTHD, string DVT_CTHD, decimal GiaTT_CTHD, int SoLuong_CTHD, int ThueVAT_CTHD
            , int TrongLuong_CTHD, string Sig_CTHD, decimal SoLot_CTHD, decimal Muctru_CTHD, string GiaThang_CTHD, string NgayChot_CTHD
            , string GiaNam_CTHD, string MucStopLoss_CTHD, decimal GiaThiTruong_CTHD, decimal MucThuong_CTHD, int ChuyenThang_CTHD)
        {
            int t = 0;
            DateTime ngayky = (DateTime)_context.Hdmbs.Where(a => a.Systemref == SystemId_CTHD_hidden).Select(a => a.Ngayky).FirstOrDefault();
            if (int.TryParse(MucStopLoss_CTHD, out t) == false && t < 0)
            {
                TempData["alertMessage"] = "Stoploss nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            if (GiaThang_CTHD != "1" && GiaThang_CTHD != "3" && GiaThang_CTHD != "5" && GiaThang_CTHD != "7"
                && GiaThang_CTHD != "9" && GiaThang_CTHD != "11" && GiaThang_CTHD != "12")
            {
                TempData["alertMessage"] = "Giá tháng nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            if (int.TryParse(GiaNam_CTHD, out t) == false && t < ngayky.Year)
            {
                TempData["alertMessage"] = "Giá năm nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            if (DateTime.Parse(NgayChot_CTHD).Year > t || (DateTime.Parse(NgayChot_CTHD).Month > int.Parse(GiaThang_CTHD) && DateTime.Parse(NgayChot_CTHD).Year == t))
            {
                TempData["alertMessage"] = "Ngày chốt cuối nhập không đúng!";
                return RedirectToAction("hdmb");
            }
            var chuyenthang = ChuyenThang_CTHD == 1 ? true : false;
            var Sp = "exec [UdscCt_hdmb];2 @idrow = '" + id + "',@systemref = '" + SystemId_CTHD_hidden + "'," +
                                               "@ref = '" + _context.Hdmbs.Where(a => a.Systemref == SystemId_CTHD_hidden).Select(a => a.Ref).FirstOrDefault().Trim() + "'," +
                                               "@soluong = '" + SoLuong_CTHD + "'," +
                                               "@trongluong = '" + TrongLuong_CTHD + "'," +
                                               "@mahang = '" + MaHang_CTHD + "'," +
                                               "@dvt = '" + "KGS" + "'," +
                                               "@giact = '" + 0 + "'," +
                                               "@giatt = '" + GiaTT_CTHD + "'," +
                                               "@vat = '" + ThueVAT_CTHD + "'," +
                                               "@giathang = '" + GiaThang_CTHD + "'," +
                                               "@gianam = '" + GiaNam_CTHD + "'," +
                                               "@sig = '" + Sig_CTHD + "'," +
                                               "@diff = '" + Muctru_CTHD + "'," +
                                               "@stoploss = '" + MucStopLoss_CTHD + "'," +
                                               "@solot = '" + SoLot_CTHD + "'," +
                                               "@status = '" + false + "'," +
                                               "@f_ngayfix = '" + DateTime.Parse(NgayChot_CTHD) + "'," +
                                               "@DVTTheoHD = '" + DVT_CTHD + "'," +
                                               "@GiaTheoHD = '" + 0 + "'," +
                                               "@GiaThiTruong = '" + GiaThiTruong_CTHD + "'," +
                                               "@MucThuong = '" + MucThuong_CTHD + "'," +
                                               "@ChuyenThang = '"+ chuyenthang + "'";
            _context.Database.ExecuteSqlRaw(Sp);
            TempData["alertMessage"] = "Cập nhật chi tiết hợp đồng OutRight thành công";
            return RedirectToAction("hdmb");
        }
        public IActionResult Delete_CTHD(string id)
        {
            var systemRef = _context.CtHdmbs.Where(a => a.IdRow == id).Select(a => a.Systemref).FirstOrDefault();
            if (_context.Fixgia.Where(a => a.Systemref == systemRef).Count() > 0)
            {
                TempData["alertMessage"] = "Hợp đồng đã fix giá, không xóa được";
                return RedirectToAction("hdmb");
            }
            else
            {
                CtHdmb ctHdmb = _context.CtHdmbs.Where(a => a.IdRow == id).FirstOrDefault();
                _context.CtHdmbs.Remove(ctHdmb);
                _context.SaveChanges();
                TempData["alertMessage"] = "Xóa chi tiết hợp đồng mua bán thành công";
                return RedirectToAction("hdmb");
            }
        }
        public void ImportDataToTable(string id, WTable wTable)
        {
            CultureInfo ci = new CultureInfo("en-us");
            var Sp = "exec [re_hdmb];5 @systemref = '" + id + "'," +
                        "@macn = '" + HttpContext.Session.GetString("UnitName") + "'";
            var re_hdmb = _context.Sp_Report_HDMBs.FromSqlRaw(Sp).ToList();
            for(int i = 0;i < re_hdmb.Count; i++)
            {
                wTable[i + 1, 0].AddParagraph().AppendText(re_hdmb[i].tenhang);
                wTable[i + 1, 0].Width = 200;
                wTable[i + 1, 1].AddParagraph().AppendText(re_hdmb[i].trongluong.ToString());
                wTable[i + 1, 2].AddParagraph().AppendText(re_hdmb[i].dvt);
                wTable[i + 1, 3].AddParagraph().AppendText(re_hdmb[i].giact.ToString());
                wTable[i + 1, 4].AddParagraph().AppendText(re_hdmb[i].thanhtien.ToString("N1", ci));
                tongCong_TablePrice = tongCong_TablePrice + re_hdmb[i].thanhtien;
            }
            wTable[re_hdmb.Count + 1, 4].AddParagraph().AppendText(tongCong_TablePrice.ToString("N1", ci));
        }
        public IActionResult ExportWord(string id)
        {
            var CurrentPath = "";
            var Sp = "exec [re_hdmb];5 @systemref = '" + id + "'," +
                        "@macn = '" + HttpContext.Session.GetString("UnitName") + "'";
            var re_hdmb = _context.Sp_Report_HDMBs.FromSqlRaw(Sp).ToList();

            var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            var ReportNameId = (from a in _context.Hdmbs join b in _context.PortfolioPayments on a.ThanhtoanId equals b.Id where a.Systemref == id select b.ReportName).FirstOrDefault();
            var ReportName = (from a in _context.ReportHdmbs where a.Id == ReportNameId select a.ReportName).FirstOrDefault();
            CurrentPath = _hostingEnvironment.WebRootPath + "\\Template\\" + ReportName + ".doc";
            Stream docStream = new FileStream(CurrentPath, FileMode.Open);
            using (WordDocument wordDocument = new WordDocument())
            {
                wordDocument.Open(docStream, FormatType.Doc);
                docStream.Dispose();
                wordDocument.Replace("«sohd»", hdmb.Sohd, true, true);
                wordDocument.Replace("«TenA»", re_hdmb[0].TenA, true, true);
                wordDocument.Replace("«DiachiA»", re_hdmb[0].DiachiA, true, true);
                wordDocument.Replace("«DienthoaiA»", re_hdmb[0].DienthoaiA, true, true); 
                wordDocument.Replace("««FaxA»", re_hdmb[0].FaxA, true, true);
                wordDocument.Replace("«TaikhoanA»", re_hdmb[0].TaikhoanA, true, true);
                wordDocument.Replace("«NganhangA»", re_hdmb[0].NganhangA, true, true);
                wordDocument.Replace("«MasothueA»", re_hdmb[0].MasothueA, true, true);
                wordDocument.Replace("«nguoikyA»", re_hdmb[0].nguoikyA, true, true);
                wordDocument.Replace("«chucvuA»", re_hdmb[0].chucvuA, true, true);
                wordDocument.Replace("«TenB»", re_hdmb[0].TenB, true, true);
                wordDocument.Replace("«DiachiB»", re_hdmb[0].DiachiB, true, true);
                wordDocument.Replace("«DienthoaiB»", re_hdmb[0].DienthoaiB, true, true);
                wordDocument.Replace("««FaxB»", re_hdmb[0].FaxB, true, true);
                wordDocument.Replace("«TaikhoanB»", re_hdmb[0].TaikhoanB, true, true);
                wordDocument.Replace("«NganhangB»", re_hdmb[0].NganhangB, true, true);
                wordDocument.Replace("«MasothueB»", re_hdmb[0].MasothueB, true, true);
                wordDocument.Replace("«nguoikyB»", re_hdmb[0].nguoikyB, true, true);
                wordDocument.Replace("«chucvuB»", re_hdmb[0].chucvuB, true, true);
                wordDocument.Replace("«TongTien»", re_hdmb[0].TongTien, true, true);
                wordDocument.Replace("«quycach»", re_hdmb[0].quycach, true, true);
                wordDocument.Replace("«BaoBi»", re_hdmb[0].quycach, true, true);
                wordDocument.Replace("«KiemDinh»", re_hdmb[0].quycach, true, true);
                wordDocument.Replace("«DiaDiemGiaoHang»", re_hdmb[0].DiaDiemGiaoHang, true, true);
                wordDocument.Replace("«ngaygiaohang»", re_hdmb[0].ngaygiaohang, true, true);
                wordDocument.Replace("«phivanchuyen»", re_hdmb[0].phivanchuyen, true, true);
                wordDocument.Replace("«phibocxep»", re_hdmb[0].phibocxep, true, true);
                wordDocument.Replace("«uyquyenA»", re_hdmb[0].uyquyenA, true, true);
                wordDocument.Replace("«uyquyenA»", re_hdmb[0].uyquyenB, true, true);
                wordDocument.Replace("«ngayhl»", re_hdmb[0].ngayhl, true, true);
                wordDocument.Replace("«liffethang»", re_hdmb[0].liffethang, true, true);
                wordDocument.Replace("«liffenam»", re_hdmb[0].liffenam, true, true);
                wordDocument.Replace("«liffesig»", re_hdmb[0].liffesig, true, true);
                wordDocument.Replace("«liffediff»", re_hdmb[0].liffediff.ToString(), true, true);
                wordDocument.Replace("«khac1»", re_hdmb[0].khac1, true, true);
                wordDocument.Replace("«MucUng»", re_hdmb[0].MucUng, true, true);
                WTable wTable = new WTable(wordDocument);
                wTable.ResetCells(re_hdmb.Count + 2, 5);
                wTable.TableFormat.Borders.BorderType = BorderStyle.Single;
                wTable.TableFormat.IsAutoResized = true;
                wTable[0, 0].AddParagraph().AppendText("TÊN HÀNG");
                wTable[0, 0].Width = 200;
                wTable[0, 1].AddParagraph().AppendText("SỐ LƯỢNG");
                wTable[0, 2].AddParagraph().AppendText("ĐVT");
                wTable[0, 3].AddParagraph().AppendText("ĐƠN GIÁ (VNĐ)");
                wTable[0, 4].AddParagraph().AppendText("THÀNH TIỀN (VNĐ)");
                wTable[re_hdmb.Count + 1, 0].AddParagraph().AppendText("Tổng cộng");
                wTable[re_hdmb.Count + 1, 0].Width = 200;
                ImportDataToTable(id, wTable);
                TextBodyPart textBody = new TextBodyPart(wordDocument);
                textBody.BodyItems.Add(wTable);
                wordDocument.Replace("[TABLE_PRICE]", textBody, true, true, true);
                MemoryStream stream = new MemoryStream();
                wordDocument.Save(stream, FormatType.Docx);
                stream.Position = 0;
                return File(stream, "application/msword", hdmb.Sohd + ".docx");
            }
        }
        public void ExportWord_Annex(string id,string fileName)
        {
            var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            using (WordDocument document = new WordDocument())
            {
                Stream docStream = System.IO.File.OpenRead(Path.GetFullPath(@"../../../MauPKHD_MUA.docx"));
                document.Open(docStream, FormatType.Docx);
                docStream.Dispose();
                document.Replace("«sophukien»", "01", true, true);
                docStream = System.IO.File.Create(Path.GetFullPath(@"Result.docx"));
                document.Save(docStream, FormatType.Docx);
                docStream.Dispose();
            }
        }
        public IActionResult ExportWord_Annex_HDMB(string id,string SoPhuKien_Annex_HDMB,string[] CheckBox_AnnexHDMB)
        {
            var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            var content = "";
            for(var i = 0;i< CheckBox_AnnexHDMB.Length; i++)
            {
                if (CheckBox_AnnexHDMB.Length == 1)
                {
                    content = CheckBox_AnnexHDMB[i];
                }
                else
                {
                    content = content + " - " + CheckBox_AnnexHDMB[i];
                }

            }
            if (_context.HdmbAnnices.Any(a => a.Systemref == id && a.Number == SoPhuKien_Annex_HDMB))
            {
                HdmbAnnex hdmbAnnex = _context.HdmbAnnices.Where(a => a.Systemref == id && a.Number == SoPhuKien_Annex_HDMB).FirstOrDefault();
                hdmbAnnex.NoiDung = content;
                hdmbAnnex.NgayTao = DateTime.Now;
                hdmbAnnex.Path = hdmb.Sohd + "_PK" + SoPhuKien_Annex_HDMB + ".doc";
                _context.HdmbAnnices.Update(hdmbAnnex);
                _context.SaveChanges();
            }
            else
            {
                HdmbAnnex hdmbAnnex = new HdmbAnnex();
                hdmbAnnex.Systemref = id;
                hdmbAnnex.Number = SoPhuKien_Annex_HDMB;
                hdmbAnnex.NoiDung = content;
                hdmbAnnex.Path = hdmb.Sohd + "_PK" + SoPhuKien_Annex_HDMB + ".doc";
                hdmbAnnex.NgayTao = DateTime.Now;
                _context.HdmbAnnices.Add(hdmbAnnex);
                _context.SaveChanges();
            }
            ExportWord_Annex(id, hdmb.Sohd + "_PK" + SoPhuKien_Annex_HDMB + ".doc");
            TempData["alertMessage"] = "Thêm chi tiết hợp đồng thành công";
            return RedirectToAction("hdmb");
        }
    }
}

