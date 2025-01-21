using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentRecordDTO
    {
        public int Id { get; set; }
        public string StudentRecordFileName { get; set; }
        public int StudentRecordUploadedBy { get; set; }
        public string Status { get; set; }
    }
}
