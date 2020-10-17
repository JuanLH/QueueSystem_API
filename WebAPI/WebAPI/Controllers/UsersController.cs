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

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user != null) {
                return Ok(_service.AddUser(user));
            }
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_service.GetUserById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            return Ok(_service.DeleteUser(id));
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user != null)
                return Ok(_service.UpdateUser(user));
            else
                return Ok();
        }

    }
}
