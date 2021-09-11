using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Nhom_hang_hoa
    {
        [Key][Required(ErrorMessage ="vui lòng nhập mã nhóm hàng")]
        public string Manhom { get; set; }
        [Required(ErrorMessage = "vui lòng nhập tên nhóm hàng")]
        public string TenNhom { get; set; }
    }
}
