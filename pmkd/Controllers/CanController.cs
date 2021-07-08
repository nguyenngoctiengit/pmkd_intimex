using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Controllers
{
    public class CanController : Controller
    {
        public tradingsystem_blContext _context;
        public CanController(tradingsystem_blContext context)
        {
            _context = context;
        }
        public IActionResult cantrongluong()
        {
            ViewBag.nhanvien = (from k in _context.Cans
                                select k.NhanVien).Distinct().ToList();
            ViewBag.baove = (from k in _context.Cans
                             select k.BaoVe).Distinct().ToList();
            ViewBag.thukho = (from k in _context.Cans
                              select k.ThuKho).Distinct().ToList();
            ViewBag.nguoilap = (from k in _context.Cans
                                select k.NguoiLap).Distinct().ToList();
            ViewBag.lanhdao = (from k in _context.Cans
                               select k.LanhDao).Distinct().ToList();
            ViewBag.stock = _context.Stocks.ToList();
            ViewBag.listcan = _context.Cans.ToList();
            return View("can");
        }
        public object GetCan(DataSourceLoadOptions loadOptions)
        {
            var item_return = (from a in _context.Cans
                              select new
                              {
                                  a.SystemId,
                                  a.HinhThucCan,
                                  a.Xeptai1,
                                  a.DateIn,
                                  a.PhieuNx,
                                  a.TruckNo,
                                  a.CustName,
                                  a.ProdCode,
                                  a.SoBao,
                                  a.BagName,
                                  a.TlBao,
                                  a.TlNet
                              }).OrderBy(a => a.Xeptai1).ToList();
            return DataSourceLoader.Load(item_return, loadOptions);
        }
        [HttpPost]
        [Route("can/can/updatetlin/{id?}")]
        public IActionResult updatetlin(Can can, string id)
        {
            var datetime = DateTime.Now;
            var item_return = _context.Cans.Where(a => a.SystemId == id).FirstOrDefault();
            if (can.TlIn != null)
            {
                if (item_return.TlIn == 0 || item_return.TlIn == null)
                {
                    item_return.TlIn = can.TlIn;
                    item_return.TimeIn = datetime.ToString("HH:mm");
                    item_return.DateIn = datetime.Date;
                }
                else if (item_return.TlIn != 0 || item_return.TlIn != null)
                {
                    item_return.TlOut = can.TlIn;
                    item_return.TimeOut = datetime.ToString("HH:mm");
                    item_return.DateIn = datetime.Date;

                }
                if ((item_return.TlIn != 0 || item_return.TlIn != null) && (item_return.TlOut != 0 || item_return != null))
                {
                    item_return.TlNet = Math.Abs(Convert.ToDecimal(item_return.TlIn - item_return.TlOut - item_return.TlBao));
                }
            }
            item_return.LaiXe = can.LaiXe;
            item_return.NguoiLap = can.NguoiLap;
            item_return.NhanVien = can.NhanVien;
            item_return.ThuKho = can.ThuKho;
            item_return.BaoVe = can.BaoVe;
            item_return.LanhDao = can.LanhDao;
            _context.Cans.Update(item_return);
            _context.SaveChanges();
            return RedirectToAction("cantrongluong");
        }
        public IActionResult phieunhapkho(int id)
        {
            var can = (from a in _context.Cans where a.IdXepTai == id select a).FirstOrDefault();
            var xt = (from a in _context.XepTais where a.Id == id select a).FirstOrDefault();
            ViewBag.idxeptai = id;
            ViewBag.tenkhach = xt.KhachHang;ViewBag.sobao = can.SoBao.ToString();
            ViewBag.makhach = xt.MaKhach;ViewBag.loaibao = can.LoaiBao.ToString();
            ViewBag.xevc = xt.SoXe;ViewBag.gw = (can.TlNet + can.TlBao).ToString();
            ViewBag.nguoigiao = can.LaiXe;ViewBag.nw = can.TlBao.ToString();
            ViewBag.nw = can.TlNet.ToString();ViewBag.rnw = can.TlNet.ToString();
            ViewBag.rnw = can.TlNet.ToString();ViewBag.tlbao = can.TlBao.ToString();
            ViewBag.hopdong = xt.HopDong;
            ViewBag.kho = can.KhoId.ToString();
            ViewBag.mahang = xt.Mahang;ViewBag.tenhang = xt.Tenhang;
            return View("phieunhapkho");
        }
        [HttpPost]
        public IActionResult themPNK(PNKViewModel pnk, int id)
        {
            var autoincrement_pnk = _context.AutomaticValuesBranches.Where(a => a.Macn == "INXBL" && a.ObjectName == "PhieuNKBLI").FirstOrDefault();
            var PrefixOfDefaultValueForId_pnk = autoincrement_pnk.PrefixOfDefaultValueForId;
            var LengthOfDefaultValueForId_pnk = (int)autoincrement_pnk.LengthOfDefaultValueForId;
            var LastValueOfColumnId_pnk = autoincrement_pnk.LastValueOfColumnId;
            var oldValue_pnk = LastValueOfColumnId_pnk.Substring(6, 6);
            var oldValueInt_pnk = Convert.ToInt32(oldValue_pnk);
            var currentValue_pnk = oldValueInt_pnk + 1;
            var nextValue_pnk = oldValueInt_pnk + 2;
            var chuoi_pnk = "00000000000000000000000000" + Convert.ToString(currentValue_pnk);
            var chuoinext_pnk = "000000000000000000000000" + Convert.ToString(nextValue_pnk);
            var parameterOut_pnk = PrefixOfDefaultValueForId_pnk + chuoi_pnk.Substring(chuoi_pnk.Length + PrefixOfDefaultValueForId_pnk.Length - LengthOfDefaultValueForId_pnk, 6);
            var next_pnk = PrefixOfDefaultValueForId_pnk + chuoinext_pnk.Substring(chuoinext_pnk.Length + PrefixOfDefaultValueForId_pnk.Length - LengthOfDefaultValueForId_pnk, 6);
            autoincrement_pnk.LastValueOfColumnId = parameterOut_pnk;
            autoincrement_pnk.NextValueOfColumnId = next_pnk;
            var autoincrement = _context.AutomaticValues.Where(a => a.ObjectName == "PHIEUNK").FirstOrDefault();
            var PrefixOfDefaultValueForId = autoincrement.PrefixOfDefaultValueForId;
            var LengthOfDefaultValueForId = autoincrement.LengthOfDefaultValueForId;
            var LastValueOfColumnId = autoincrement.LastValueOfColumnId;
            var oldValue = Convert.ToInt32(LastValueOfColumnId.Substring(PrefixOfDefaultValueForId.Length, 15));
            var chuoi = "0000000000000000" + Convert.ToString(oldValue + 1);
            var ParamateOut = PrefixOfDefaultValueForId + chuoi.Substring(chuoi.Length + PrefixOfDefaultValueForId.Length - 15, 12);
            autoincrement.LastValueOfColumnId = ParamateOut;
            Can ca = _context.Cans.Where(a => a.IdXepTai == id).FirstOrDefault();
            XepTai xt = _context.XepTais.Where(a => a.Id == id).FirstOrDefault();
            ca.PhieuId = ParamateOut;
            ca.PhieuNx = parameterOut_pnk;
            xt.PhieuNhapKho = parameterOut_pnk;
            xt.PhieuNhapKhoId = ParamateOut;
            NhapKho nk = new NhapKho();
            nk.Id = ParamateOut;
            nk.LyDo = 1;
            nk.GhiChu = pnk.nk.GhiChu;
            nk.Macn = HttpContext.Session.GetString("UnitName");
            nk.SoPhieu = parameterOut_pnk;
            nk.MaKho = pnk.nk.MaKho;
            nk.TenKho = (from a in _context.Stocks where a.StockId == Int64.Parse(pnk.nk.MaKho) select a.StockName).First();
            nk.TenKhach = pnk.nk.TenKhach;
            nk.MaKhach = pnk.nk.MaKhach;
            nk.NguoiGiao = pnk.nk.NguoiGiao;
            nk.Approve = false;
            nk.XeVc = pnk.nk.XeVc;
            nk.NgayChungTu = pnk.nk.NgayChungTu;
            nk.CreateDate = DateTime.Now;
            
            return RedirectToAction("can");
        }
    }
}
