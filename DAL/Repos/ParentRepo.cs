using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ParentRepo : Repo, IRepo<Parent, int, Parent>
    {
        public Parent Create(Parent obj)
        {
            db.Parents.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Parents.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Parent Get(int id)
        {
            return db.Parents.Find(id);
        }

        public List<Parent> Get()
        {
            return db.Parents.ToList();
        }

        public Parent Update(Parent obj)
        {
            var ex = Get(obj.ParentId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}
