using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NkInput
    {
        public string SystemId { get; set; }
        public string MaCn { get; set; }
        public string LoaiCt { get; set; }
        public string SoCt { get; set; }
        public string ContractNo { get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NguoiNhap { get; set; }
        public string SupplierCode { get; set; }
        public string Supplier { get; set; }
        public string TkNhap { get; set; }
        public DateTime NgayTk { get; set; }
        public string MaKho { get; set; }
        public string Ngoaite { get; set; }
        public decimal TyGia { get; set; }
        public decimal TongThueTtdb { get; set; }
        public decimal TongThueNk { get; set; }
        public decimal TongTien { get; set; }
        public decimal Thanhtien { get; set; }
        public string SoHdVat { get; set; }
        public DateTime NgayHdVat { get; set; }
        public string SerialVat { get; set; }
        public string DienGiai { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime DateEdit { get; set; }
    }
}
