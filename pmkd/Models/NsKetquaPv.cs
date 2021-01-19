using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsKetquaPv
    {
        public long Id { get; set; }
        public string Macn { get; set; }
        public string MaUv { get; set; }
        public decimal DChuyenmon { get; set; }
        public decimal DKinhnghiem { get; set; }
        public decimal DKynang { get; set; }
        public decimal DNgoaingu { get; set; }
        public decimal DTinhoc { get; set; }
        public decimal DPhongcach { get; set; }
        public decimal DNgoaihinh { get; set; }
        public int KqLan { get; set; }
        public string DiaDiemPv { get; set; }
        public string TgPv { get; set; }
        public string ThanhvienPv { get; set; }
        public string GhiChu { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserEdit { get; set; }
        public DateTime? DateEdit { get; set; }
    }
}
