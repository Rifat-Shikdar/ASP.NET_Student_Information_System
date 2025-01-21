using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAttendenceFeature
    {
        List<Attendence> GetAttendancesByStudentId(int studentId);
        Attendence AddAttendance(Attendence attendance);
        Attendence UpdateAttendance(Attendence attendance);
        bool DeleteAttendance(int attendanceId);
    }
}
