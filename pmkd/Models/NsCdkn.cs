using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class NsCdkn
    {
        public int Id { get; set; }
        public string MaCbnv { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public string SoQdkn { get; set; }
        public bool? TgBks { get; set; }
        public string CdBks { get; set; }
        public bool? TgHdqt { get; set; }
        public string CdHdqt { get; set; }
        public string NoiDungCd { get; set; }
        public string GhiChu { get; set; }
    }
}
