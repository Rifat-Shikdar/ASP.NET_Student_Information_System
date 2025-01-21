using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IParentFeature
    {
        Parent GetParentByStudentId(int studentId);
        Parent AddParent(Parent parent);
        Parent UpdateParent(Parent parent);
        bool DeleteParent(int parentId);
    }
}
