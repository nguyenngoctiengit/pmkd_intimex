using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class Nhom_hang_hoa
    {
        [Key]
        [Required(ErrorMessage = "vui lòng nhập mã nhóm hàng")]
        public string Manhom { get; set; }
        [Required(ErrorMessage = "vui lòng nhập tên nhóm hàng")]
        public string TenNhom { get; set; }
    }
}
