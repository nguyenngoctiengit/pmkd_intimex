using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Saveinvoice
    {
        public string SystemId { get; set; }
        public string Id { get; set; }
        public string Macn { get; set; }
        public string Invoice { get; set; }
        public string Systemref { get; set; }
        public string Shd { get; set; }
        public DateTime DateHd { get; set; }
        public string Cbuyer { get; set; }
        public string Buyer { get; set; }
        public string Diachi { get; set; }
        public string Masothue { get; set; }
        public int ThueSuat { get; set; }
        public string GhiChu { get; set; }
        public string Shiper { get; set; }
        public string PreCarri { get; set; }
        public string PortLoad1 { get; set; }
        public string Delivery { get; set; }
        public string BillNo { get; set; }
        public string Cont { get; set; }
        public bool ChkDongia { get; set; }
        public bool IsFix { get; set; }
        public string Ngoaite { get; set; }
        public decimal Soluong { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountVat { get; set; }
        public decimal Tygia { get; set; }
        public decimal TongTien { get; set; }
        public string StBangchu { get; set; }
        public string Payment { get; set; }
        public DateTime? DateIv { get; set; }
        public string Bank { get; set; }
        public bool Medit { get; set; }
        public string SoTk { get; set; }
        public string SerialVat { get; set; }
        public DateTime DateVat { get; set; }
        public string SoHdvat { get; set; }
        public string CodeImportCountry { get; set; }
        public string ImportCountry { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserEdit { get; set; }
        public string DateEdit { get; set; }
        public string TrangThai { get; set; }
        public string TypeInv { get; set; }
        public int Tuan { get; set; }
        public int Thang { get; set; }
        public int Qui { get; set; }
        public int Nam { get; set; }
        public int NamLv { get; set; }
        public bool DuyetTuan { get; set; }
        public bool DuyetThang { get; set; }
        public bool DuyetQui { get; set; }
        public bool DuyetNam { get; set; }
        public byte[] TimestampColumn { get; set; }
    }
}
