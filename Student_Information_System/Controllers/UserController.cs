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
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/user/all")]
        public HttpResponseMessage Get()
        {
            var data = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/user/create")]
        public HttpResponseMessage Create(UserDTO userDTO)
        {
            UserService.Create(userDTO);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        [Route("api/user/update/{id}")]
        public HttpResponseMessage Update(int id, UserDTO userDTO)
        {
            UserService.Update(id, userDTO);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("api/user/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
