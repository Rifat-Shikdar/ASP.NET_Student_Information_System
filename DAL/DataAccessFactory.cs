using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Student, int, Student> StudentData()
        {
            return new StudentRepo();
        }
        public static IRepo<Parent, int, Parent> ParentData()
        {
            return new ParentRepo();
        }
        public static IRepo<Attendence, int, Attendence> AttendenceData()
        {
            return new AttendenceRepo();
        }
        public static IRepo<Schedule, int, Schedule> ScheduleData()
        {
            return new ScheduleRepo();
        }
        public static IRepo<StudentRecord, int, StudentRecord> StudentRecordData()
        {
            return new StudentRecordRepo();
        }
        

    }
}
