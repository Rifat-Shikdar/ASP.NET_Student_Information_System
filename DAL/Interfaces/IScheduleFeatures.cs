using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IScheduleFeatures
    {
        List<Schedule> GetSchedulesByStudentId(int studentId);
        Schedule AddSchedule(Schedule schedule);
        Schedule UpdateSchedule(Schedule schedule);
        bool DeleteSchedule(int scheduleId);
    }
}
