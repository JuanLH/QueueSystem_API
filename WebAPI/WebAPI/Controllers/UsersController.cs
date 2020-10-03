using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.Data;
using WebAPI.Data.Models;

namespace Users.Controller
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private IUserService _service;

        public UsersController(IUserService service) {
            this._service = service;
        }

        [HttpGet("hello")]
        public string sayHello()
        {
            return "Hello world";
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user != null) {
                _service.AddUser(user);
            }
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllUsers());
        }
    }
}
