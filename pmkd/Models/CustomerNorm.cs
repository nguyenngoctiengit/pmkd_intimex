using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace pmkd.Models
{
    public partial class CustomerNorm
    {
        [Required]
        public long Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)][Required]
        public string Makhach { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Nhomhang { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Macn { get; set; }
        public decimal ValueNorm { get; set; }
        public decimal ValueDmgh { get; set; }
        public string Ghichu { get; set; }
        [Required]
        public string NguoiGd { get; set; }
        public string ChucvuNguoigd { get; set; }
        public string UserCreate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string UserModify { get; set; }
        public DateTime? DateModify { get; set; }
        public bool? GdMua { get; set; }
        public bool? GdBan { get; set; }
    }
}
