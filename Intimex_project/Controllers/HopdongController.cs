﻿using Application.Parameter;
using Data.Models.SignalR;
using Data.Models.Trading_system;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Application.AutoId;

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
            return View("hdmb");
        }
        [HttpPost]
        public IActionResult Fill_Form_HDMB(string Systemref)
        {
            var Name_IntKy = "";
            var IntKy = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.IntKy).FirstOrDefault().Trim();
            var Client_Ky = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.ClientKy).FirstOrDefault().Trim();
            var Name_ClientKy = "";
            if (IntKy == null || IntKy == "")
            {
                Name_IntKy = "";
            }
            else
            {
                Name_IntKy = (from a in _context.Signers where a.MaKhach == IntKy.Substring(0, IntKy.Length - 1) && a.Stt == int.Parse(IntKy.Substring(IntKy.Length - 1)) select a.Nguoiky).FirstOrDefault().Trim() + " chức vụ " + (from a in _context.Signers where a.MaKhach == IntKy.Substring(0, IntKy.Length - 1) && a.Stt == int.Parse(IntKy.Substring(IntKy.Length - 1)) select a.Chucvu).FirstOrDefault();
            }
            if (Client_Ky == null || Client_Ky == "")
            {
                Name_ClientKy = "";
            }
            else
            {
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
        public IActionResult AddHopDong(Hdmb hdmb)
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
                _context.Hdmbs.Add(item);
                _context.SaveChanges();
                TempData["alertMessage"] = "Thêm hợp đồng thành công";
                return RedirectToAction("hdmb");

            }
        }

    }
}

        