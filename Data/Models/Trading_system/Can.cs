using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Can
    {
        public string SystemId { get; set; }
        public string TruckNo { get; set; }
        public DateTime? DateIn { get; set; }
        public string TimeIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string TimeOut { get; set; }
        public decimal? TlIn { get; set; }
        public decimal TlCont { get; set; }
        public decimal TlCont1 { get; set; }
        public decimal? TlOut { get; set; }
        public string PhieuCan { get; set; }
        public bool? TypeCont { get; set; }
        public string ContNo { get; set; }
        public string ContNo1 { get; set; }
        public string SealNo { get; set; }
        public string SealNo1 { get; set; }
        public decimal? TlNet { get; set; }
        public string Dvt { get; set; }
        public int? HinhThucCan { get; set; }
        public string GhiChu { get; set; }
        public string Macn { get; set; }
        public string UserName { get; set; }
        public int? CachCan { get; set; }
        public decimal? TlDau1 { get; set; }
        public decimal? TlDau2 { get; set; }
        public long? IdXepTai { get; set; }
        public int? IsPrint { get; set; }
        public int SoBao { get; set; }
        public int LoaiBao { get; set; }
        public string BagName { get; set; }
        public decimal TlBao { get; set; }
        public decimal Quanlitybag { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string IdLenhXuat { get; set; }
        public byte[] Timestamp { get; set; }
        public long? IsF { get; set; }
        public int? Aprove { get; set; }
        public int? Status { get; set; }
        public string GhiChu1 { get; set; }
        public int? Xeptai1 { get; set; }
        public string PhieuId { get; set; }
        public string PhieuNx { get; set; }
        public string Sohd { get; set; }
        public string Idhopdong { get; set; }
        public int? KhoId { get; set; }
        public bool Chon { get; set; }
        public string TruckNo2 { get; set; }
        public decimal? AddValue { get; set; }
        public string NguoiGiao { get; set; }
        public long? SolenhxuatId { get; set; }
        public int? IsPrintNxk { get; set; }
        public string TimeFinish { get; set; }
        public string TimeCan { get; set; }
        public int? Socont { get; set; }
        public int? Sobao1cont { get; set; }
        public int? Loaicont { get; set; }
        public string LaiXe { get; set; }
        public string NhanVien { get; set; }
        public string BaoVe { get; set; }
        public string NguoiLap { get; set; }
        public string ThuKho { get; set; }
        public string LanhDao { get; set; }
        public decimal? Tlphieu { get; set; }

        public virtual XepTai IdXepTaiNavigation { get; set; }
    }
}
