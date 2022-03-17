﻿using Application.AutoId;
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

namespace Intimex_project.Controllers
{
    public class HopdongController : Controller
    {
        public DateTime NgayKy;
        private readonly tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
        public HopdongController()
        {
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
                            IsNoKhoDoi = a.IsNoKhoDoi

                        }).FirstOrDefault();
            return Json(data);
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
            if (GiaThang_CTHD != "1" || GiaThang_CTHD != "3" || GiaThang_CTHD != "5" || GiaThang_CTHD != "7"
                || GiaThang_CTHD != "9" || GiaThang_CTHD != "11" || GiaThang_CTHD != "12")
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


    }
}

