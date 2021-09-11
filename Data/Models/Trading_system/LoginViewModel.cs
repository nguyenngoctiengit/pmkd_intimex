using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models.Trading_system
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="vui long nhap ten dang nhap")]
        [Key]public string UserName1 { get; set; }
        [Required(ErrorMessage = "vui long nhap mat khau")]
        public string PassWord1 { get; set; }
        public string userBranch { get; set; }
    }
}
