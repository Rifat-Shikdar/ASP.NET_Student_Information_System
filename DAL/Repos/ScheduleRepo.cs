using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ScheduleRepo : Repo, IRepo<Schedule, int, Schedule>
    {
        public Schedule Create(Schedule obj)
        {
            db.Schedules.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Schedules.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Schedule Get(int id)
        {
            return db.Schedules.Find(id);
        }

        public List<Schedule> Get()
        {
            return db.Schedules.ToList();
        }

        public Schedule Update(Schedule obj)
        {
            var ex = Get(obj.ScheduleId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}
