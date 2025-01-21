using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRecordRepo : Repo, IRepo<StudentRecord, int, StudentRecord>
    {
        public StudentRecord Create(StudentRecord obj)
        {
            db.StudentRecords.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.StudentRecords.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public StudentRecord Get(int id)
        {
            return db.StudentRecords.Find(id);
        }

        public List<StudentRecord> Get()
        {
            return db.StudentRecords.ToList();
        }

        public StudentRecord Update(StudentRecord obj)
        {
            var ex = Get(obj.StudentRecordId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}
