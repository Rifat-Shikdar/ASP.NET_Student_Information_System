using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Grade { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


        [ForeignKey("Parent")]
        public int ParentId { get; set; }


        public virtual Parent Parent { get; set; }

        public virtual ICollection<Attendence> Attendences { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

        public Student()
        {
            Attendences = new List<Attendence>();
            Schedules = new List<Schedule>();
        }
    }
}
