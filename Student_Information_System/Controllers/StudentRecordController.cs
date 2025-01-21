using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student_Information_System.Controllers
{
    public class StudentRecordController : ApiController
    {
        [HttpGet]
        [Route("api/studentrecord/all")]
        public HttpResponseMessage Get()
        {
            var data = StudentRecordService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/studentrecord/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = StudentRecordService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/studentrecord/create")]
        public HttpResponseMessage Create(StudentRecordDTO studentRecordDTO)
        {
            StudentRecordService.Create(studentRecordDTO);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        [Route("api/studentrecord/update/{id}")]
        public HttpResponseMessage Update(int id, StudentRecordDTO studentRecordDTO)
        {
            StudentRecordService.UpdateStudentRecord(id, studentRecordDTO);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("api/studentrecord/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            StudentRecordService.DeleteStudentRecord(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
