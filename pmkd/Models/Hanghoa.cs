using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace pmkd.Models
{
    public partial class Hanghoa
    {
        [Required]
        public string Idhanghoa { get; set; }
        [Key]
        public string Mahang { get; set; }
        [Required]
        public string Tenhang { get; set; }
        public string Tenhangvat { get; set; }
        public string MaNhom { get; set; }
        public string Dvt { get; set; }
        public int? Vat { get; set; }
        public short? Sudung { get; set; }
        public string Fullname { get; set; }
        public string Quicach { get; set; }
        public string Baobi { get; set; }
        public string Kiemdinh { get; set; }
        public bool? Visible { get; set; }
        public short? OrderNhom { get; set; }
        public decimal? DoAm { get; set; }
        public decimal? HatDen { get; set; }
        public decimal? TapChat { get; set; }
        public decimal? HatVo { get; set; }
    }

}
