using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class StudentRecord
    {
        public int StudentRecordId { get; set; }
        public string StudentRecordFileName { get; set; }

        [ForeignKey("User")]
        public int StudentRecordUploadedBy { get; set; }
        public string Status { get; set; }


        public virtual User User { get; set; }
    }
}
