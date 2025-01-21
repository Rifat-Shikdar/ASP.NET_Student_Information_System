using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ScheduleDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        public string ClassName { get; set; }
        public DateTime ClassTime { get; set; }
    }
}
