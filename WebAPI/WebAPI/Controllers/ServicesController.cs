using Microsoft.AspNetCore.Mvc;
using Services.Data;

namespace WebAPI.Controllers
{
    [Route("api/Services")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private IServiceService _service;

        public ServicesController(IServiceService service)
        {
            this._service = service;
        }

        [HttpPost("AddService")]
        public IActionResult AddUser([FromBody] Service service)
        {
            if (service != null)
            {
                return Ok(_service.AddService(service));
            }
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllService());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_service.GetServiceById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            return Ok(_service.DeleteService(id));
        }

        [HttpPut("UpdateService")]
        public IActionResult UpdateUser([FromBody] Service user)
        {
            if (user != null)
                return Ok(_service.UpdateService(user));
            else
                return Ok();
        }
    }
}
