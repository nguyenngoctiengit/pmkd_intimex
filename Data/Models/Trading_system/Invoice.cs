using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Invoice
    {
        public string Id { get; set; }
        public string Macn { get; set; }
        public string Invoice1 { get; set; }
        public string Systemref { get; set; }
        public string Shd { get; set; }
        public DateTime DateHd { get; set; }
        public string Cbuyer { get; set; }
        public string Buyer { get; set; }
        public string Shiper { get; set; }
        public string PreCarri { get; set; }
        public string Voy1 { get; set; }
        public string Vessel { get; set; }
        public string Voy2 { get; set; }
        public string PortLoad1 { get; set; }
        public string Delivery { get; set; }
        public string BillNo { get; set; }
        public DateTime DateBill { get; set; }
        public string LcNo { get; set; }
        public string DateLc { get; set; }
        public string Goods { get; set; }
        public string TMarks { get; set; }
        public string Marks { get; set; }
        public string Ngoaite { get; set; }
        public decimal Tienung { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string Payment { get; set; }
        public DateTime? DateIv { get; set; }
        public string Packing { get; set; }
        public string Bank { get; set; }
        public string BankCode { get; set; }
        public bool Medit { get; set; }
        public string LoaiIv { get; set; }
        public bool Payable { get; set; }
        public bool Nhapkho { get; set; }
        public bool NhapkhoNd { get; set; }
        public string Ten { get; set; }
        public string Giaohang { get; set; }
        public string CodeImportCountry { get; set; }
        public string ImportCountry { get; set; }
        public string CodeTranshipmentCountry { get; set; }
        public string TranshipmentCountry { get; set; }
        public string UserCreate { get; set; }
        public string Issue { get; set; }
        public string MainUnit { get; set; }
        public string SubUnit { get; set; }
        public DateTime? NgayLam { get; set; }
        public byte[] TimestampColumn { get; set; }
        public bool IsTach { get; set; }
        public string ProIvId { get; set; }
        public DateTime? NgayThanhKhoan { get; set; }
        public bool IsXuat { get; set; }
        public bool IsXuatThiTruong { get; set; }
        public string UserXuat { get; set; }
        public string KyBaoCao { get; set; }
        public DateTime? NgayTrinhCt { get; set; }
        public DateTime? NgayChuyenKt { get; set; }
    }
}
