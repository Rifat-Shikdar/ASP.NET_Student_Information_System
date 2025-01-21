using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentScheduleDTO : StudentDTO
    {
        public List<ScheduleDTO> Schedules { get; set; }
        public StudentScheduleDTO()
        {
            Schedules = new List<ScheduleDTO>();
        }
    }
}
