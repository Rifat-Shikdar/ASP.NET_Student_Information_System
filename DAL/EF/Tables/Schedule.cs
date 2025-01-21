using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public string ClassName { get; set; }
        public DateTime ClassTime { get; set; }


        public virtual Student Student { get; set; }
    }
}
