using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class NkOutputDetail
    {
        public int Id { get; set; }
        public string SystemId { get; set; }
        public string Makho { get; set; }
        public string Tokhai { get; set; }
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public decimal Soluong { get; set; }
        public decimal Dongia { get; set; }
        public decimal Thanhtien { get; set; }
        public bool CheckGia { get; set; }
    }
}
