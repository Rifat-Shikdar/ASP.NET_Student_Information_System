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
    public class ScheduleController : ApiController
    {
        [HttpGet]
        [Route("api/schedule/all")]
        public HttpResponseMessage Get()
        {
            var data = ScheduleService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/schedule/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = ScheduleService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/schedule/create")]
        public HttpResponseMessage Create(ScheduleDTO scheduleDTO)
        {
            ScheduleService.Create(scheduleDTO);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        [Route("api/schedule/update/{id}")]
        public HttpResponseMessage Update(int id, ScheduleDTO scheduleDTO)
        {
            ScheduleService.UpdateSchedule(id, scheduleDTO);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("api/schedule/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            ScheduleService.DeleteSchedule(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
