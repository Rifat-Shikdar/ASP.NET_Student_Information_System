using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Attendence
    {
        public int AttendenceId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
       
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public virtual Student Student { get; set; }

    }
}
