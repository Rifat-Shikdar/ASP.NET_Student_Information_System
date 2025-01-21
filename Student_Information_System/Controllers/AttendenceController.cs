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
    public class AttendenceController : ApiController
    {
        [HttpGet]
        [Route("api/attendance/all")]
        public HttpResponseMessage Get()
        {
            var data = AttendanceService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/attendance/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = AttendanceService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/attendance/create")]
        public HttpResponseMessage Create(AttendenceDTO attendanceDTO)
        {
            AttendanceService.Create(attendanceDTO);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        [Route("api/attendance/update/{id}")]
        public HttpResponseMessage Update(int id, AttendenceDTO attendanceDTO)
        {
            AttendanceService.Update(id, attendanceDTO);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("api/attendance/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            AttendanceService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
