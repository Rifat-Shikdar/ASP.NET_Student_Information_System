using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepo : Repo, IRepo<Student, int, Student>
    {
        public Student Create(Student obj)
        {
            db.Students.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Students.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Student Get(int id)
        {
            var student = db.Students.Find(id);
            return student;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student Update(Student obj)
        {

            var ex = Get(obj.StudentId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}

