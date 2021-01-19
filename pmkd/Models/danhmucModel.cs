using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pmkd.Models
{
    public class danhmucModel
    {
        public IEnumerable<Nhom_hang_hoa> _nhomhanghoa { get; set; }
        public IEnumerable<Hanghoa> _hanghoa { get; set; }
    }
}
