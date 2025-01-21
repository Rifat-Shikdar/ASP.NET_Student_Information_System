using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class SISContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<StudentRecord> StudentRecords { get; set; }
        public DbSet<Attendence> Attendences { get; set; }

    }
}
    