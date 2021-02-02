using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace pmkd.Models
{
    public partial class Signer
    {
        [Required]
        public long Id { get; set; }
        public int Stt { get; set; }
        [Required]
        public string MaKhach { get; set; }
        [Required(ErrorMessage ="vui lòng nhập người đại diện")]
        public string Nguoiky { get; set; }
        [Required(ErrorMessage = "vui lòng nhập chức vụ người đại diện")]
        public string Chucvu { get; set; }
        public string Uyquyen { get; set; }
        public bool? Visible { get; set; }
    }
}
