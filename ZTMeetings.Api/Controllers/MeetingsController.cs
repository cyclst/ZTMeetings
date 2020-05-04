using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZTMeetings.Api.Models;

namespace ZTMeetings.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Booking>>> Get()
        {
            return new List<Booking>();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IEnumerable<Employee> employees)
        {
            return Ok();
        }
    }
}
