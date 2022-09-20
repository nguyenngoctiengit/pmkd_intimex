using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.SignalR
{
    public partial class Menu_test
    {
        [Key]
        public int ID { get; set; }
        public int ID_Parent { get; set; }
        public string MenuName { get; set; }
        public string Controller { get; set; }
        public string Event { get; set; }
        public string Icon { get; set; }
        public int Lv { get; set; }
    }
}
