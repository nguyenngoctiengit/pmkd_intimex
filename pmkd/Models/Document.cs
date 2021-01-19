using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class Document
    {
        public long DocId { get; set; }
        public long DocStyleId { get; set; }
        public long DocTypeId { get; set; }
        public DateTime DocDate { get; set; }
        public string NumberSign { get; set; }
        public string NumberCome { get; set; }
        public DateTime? DateCome { get; set; }
        public int NumberOfPage { get; set; }
        public long DocPlaceId { get; set; }
        public string Contents { get; set; }
        public int DocLever { get; set; }
        public string Singer { get; set; }
        public string Note { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserCreate { get; set; }
        public string Macn { get; set; }
        public int IsPublic { get; set; }
        public long DepId { get; set; }
        public bool IsDelete { get; set; }
    }
}
