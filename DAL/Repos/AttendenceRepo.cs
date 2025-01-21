using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AttendenceRepo : Repo, IRepo<Attendence, int, Attendence>
    {
        public Attendence Create(Attendence obj)
        {

            db.Attendences.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Attendences.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Attendence Get(int id)
        {
            return db.Attendences.Find(id);
        }

        public List<Attendence> Get()
        {
            return db.Attendences.ToList();
        }

        public Attendence Update(Attendence obj)
        {
            var ex = Get(obj.AttendenceId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}
