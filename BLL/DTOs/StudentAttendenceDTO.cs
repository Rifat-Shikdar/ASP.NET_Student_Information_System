using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentAttendenceDTO : StudentDTO
    {
        public List<AttendenceDTO> Attendences { get; set; }
        public StudentAttendenceDTO()
        {
            Attendences = new List<AttendenceDTO>();
        }
    }
}
