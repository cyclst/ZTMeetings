using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ZTMeetings.Api.CommandHandlers;
using ZTMeetings.Api.Commands;
using ZTMeetings.Api.Dtos;

namespace ZTMeetings.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MeetingsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("")]
        public async Task<ActionResult<string>> Get()
        {
            return Guid.NewGuid().ToString();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MeetingDto dto)
        {
            var response = await _mediator.Send(new AddMeetingCommand(dto.Id, dto.DateTime));

            if (!response.IsSuccessful)
                return BadRequest(response.MessageString);

            return Ok();
        }

        [HttpPost("{id}/bookings")]
        public async Task<IActionResult> Post(Guid id, [FromBody] IReadOnlyCollection<EmployeeDto> employees)
        {
            var response = await _mediator.Send(new RequestBookingCommand(id, employees));

            if (!response.IsSuccessful)
                return BadRequest(response.MessageString);

            return Ok();
        }

        [HttpGet("{id}/bookings")]
        public async Task<ActionResult<IEnumerable<BookingDto>>> Get(string id)
        {
            return new List<BookingDto>();
        }
    }
}
