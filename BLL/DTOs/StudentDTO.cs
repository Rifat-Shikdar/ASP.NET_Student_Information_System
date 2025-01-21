using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime? DOB { get; set; }
        public string Grade { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int ParentId { get; set; }
    }
}
