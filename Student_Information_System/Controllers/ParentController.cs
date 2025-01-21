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
    public class ParentController : ApiController
    {
            [HttpGet]
            [Route("api/parent/all")]
            public HttpResponseMessage Get()
            {
                var data = ParentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }

            [HttpGet]
            [Route("api/parent/{id}")]
            public HttpResponseMessage Get(int id)
            {
                var data = ParentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }

            [HttpPost]
            [Route("api/parent/create")]
            public HttpResponseMessage Create(ParentDTO p)
            {
                ParentService.Create(p);
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            [HttpPut]
            [Route("api/parent/update/{id}")]
            public HttpResponseMessage Update(int id, ParentDTO p)
            {
                ParentService.Update(id, p);
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            [HttpDelete]
            [Route("api/parent/delete/{id}")]
            public HttpResponseMessage Delete(int id)
            {
                ParentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
}
