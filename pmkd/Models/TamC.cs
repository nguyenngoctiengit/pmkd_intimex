using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class TamC
    {
        public string SystemId { get; set; }
        public string TruckNo { get; set; }
        public DateTime? DateIn { get; set; }
        public string TimeIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string TimeOut { get; set; }
        public string CustCode { get; set; }
        public string CustPresent { get; set; }
        public string CustName { get; set; }
        public string CustAdd { get; set; }
        public string Taxcode { get; set; }
        public string ProdCode { get; set; }
        public string ProdName { get; set; }
        public decimal? TlIn { get; set; }
        public decimal? TlCont { get; set; }
        public decimal? TlCont1 { get; set; }
        public decimal? TlOut { get; set; }
        public string VatNo { get; set; }
        public string Serial { get; set; }
        public DateTime? NgayHd { get; set; }
        public bool? Tthai { get; set; }
        public decimal? Dongia { get; set; }
        public decimal? Dongia1 { get; set; }
        public decimal? Trigia { get; set; }
        public decimal? Vat { get; set; }
        public string Payment { get; set; }
        public bool? TypeCont { get; set; }
        public string ContNo { get; set; }
        public string ContNo1 { get; set; }
        public string SealNo { get; set; }
        public string SealNo1 { get; set; }
        public decimal? TlNet { get; set; }
        public string Taikhoan { get; set; }
        public decimal? Tienthue { get; set; }
        public decimal? Tongtrigia { get; set; }
        public string Dvt { get; set; }
        public decimal? Trigia1 { get; set; }
        public decimal? Trigiatruocthue { get; set; }
        public int XepTai { get; set; }
        public int HinhThucCan { get; set; }
        public string GhiChu { get; set; }
        public string SystemRefHd { get; set; }
        public string Macn { get; set; }
        public string Username { get; set; }
        public int SoBao { get; set; }
        public decimal Tlbao { get; set; }
        public int LoaiBao { get; set; }
    }
}
