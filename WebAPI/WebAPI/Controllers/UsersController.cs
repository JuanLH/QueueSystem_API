using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.Data;
using WebAPI.Data.Models;

namespace Trips.Controller
{
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly DataContext _dataContext;
        private IUserService _service;
        public UsersController(IUserService service) {
            this._service = service;
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user != null) {
                _service.AddUser(user);
            }
            return Ok();
        }
    }
}
