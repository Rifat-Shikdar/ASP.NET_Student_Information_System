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
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/student/all")]
        public HttpResponseMessage Get()
        {
            var data = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/student/create")]
        public HttpResponseMessage Create(StudentDTO c)
        {
            StudentService.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("api/student/update/{id}")]
        public HttpResponseMessage Update(int id, StudentDTO s)
        {
            StudentService.Update(id, s);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("api/student/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            StudentService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }


        [HttpGet]
        [Route("api/student/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = StudentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/student/{id}/parent")]
        public HttpResponseMessage GetwithParent(int id)
        {
            var data = StudentService.GetWithParent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/student/{id}/attendence")]
        public HttpResponseMessage GetwithAttendence(int id)
        {
            var data = StudentService.GetWithAttendance(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/student/{id}/schedule")]
        public HttpResponseMessage GetwithSchedule(int id)
        {
            var data = StudentService.GetWithSchedule(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/student/search/{name}")]
        public HttpResponseMessage Search(string name)
        {
            var data = StudentService.SearchByName(name);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
