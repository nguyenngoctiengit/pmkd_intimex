using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class KhkdTiep
    {
        public long Id { get; set; }
        public string MaDv { get; set; }
        public string LoaiHinh { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int Tuan { get; set; }
        public string NhomHang { get; set; }
        public string MaHang { get; set; }
        public string HangHoa { get; set; }
        public string Dvt { get; set; }
        public double SoLuong { get; set; }
        public double TriGia { get; set; }
        public int Type { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsLock { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
