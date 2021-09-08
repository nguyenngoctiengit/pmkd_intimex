using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class HangHoaCanGiaiQuyet
    {
        public long Id { get; set; }
        public string MaDv { get; set; }
        public int Tuan { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string NoiDung { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsLock { get; set; }
        public int Type { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
