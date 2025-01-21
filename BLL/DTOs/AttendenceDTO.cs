using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AttendenceDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
