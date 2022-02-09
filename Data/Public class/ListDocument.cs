using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Public_class
{
    public class ListDocument
    {
        public static List<Documents> Documents { get; set; } = new List<Documents>();
        public static List<Documents> GetListDocument()
        {
            Documents.Add(new Documents { Id = 1, Name = "\\1- Quy định - Quy chế" });
            Documents.Add(new Documents { Id = 1, Name = "\\2- Sổ tay CBCNV" });
            Documents.Add(new Documents { Id = 1, Name = "\\3- Văn bản mẫu\\HD thể thức và kỹ thuật trình bày văn bản" });
            Documents.Add(new Documents { Id = 1, Name = "\\3- Văn bản mẫu\\Mẫu văn bản" });
            Documents.Add(new Documents { Id = 1, Name = "\\3- Văn bản mẫu" });
            Documents.Add(new Documents { Id = 3, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\1. Điều lệ Công ty" });
            Documents.Add(new Documents { Id = 3, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\2. Nội quy, quy định Công ty" });
            Documents.Add(new Documents { Id = 3, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\3. Quy chế (QC) Công ty" });
            Documents.Add(new Documents { Id = 3, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\4. Văn bản hướng dẫn(HD) thực hiện" });
            Documents.Add(new Documents { Id = 3, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\5. Biểu mẫu" });
            Documents.Add(new Documents { Id = 3, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\6. Phân công công việc các phòng ban" });
            Documents.Add(new Documents { Id = 1, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\Biểu mẫu" });
            Documents.Add(new Documents { Id = 1, Name = "\\4- Phòng Ban\\01- Phòng TC-HC\\Qui định" });
            Documents.Add(new Documents { Id = 1, Name = "\\4- Phòng Ban" });
            return Documents.ToList();
        }
    }
}
