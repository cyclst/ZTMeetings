using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ZTMeetings.Api.CommandHandlers;
using ZTMeetings.Api.Commands;
using ZTMeetings.Api.Dtos;
using ZTMeetings.Api.Infrastructure;

namespace ZTMeetings.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMeetingRepository _meetingRepository;
        private readonly IMapper _mapper;

        public MeetingsController(IMediator mediator, IMeetingRepository meetingRepository, IMapper mapper)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _meetingRepository = meetingRepository ?? throw new ArgumentNullException(nameof(meetingRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("")]
        public ActionResult<string> Get()
        {
            return "Welcome :)";
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MeetingDto dto)
        {
            var response = await _mediator.Send(new AddMeetingCommand(dto.Id, dto.DateTime));

            if (!response.IsSuccessful)
                return BadRequest(response.MessageString);

            return Ok();
        }

        [HttpPost("{id}/bookings")]
        public async Task<ActionResult> Post(Guid id, [FromBody] IReadOnlyCollection<EmployeeDto> employees)
        {
            var response = await _mediator.Send(new RequestBookingCommand(id, employees));

            if (!response.IsSuccessful)
                return BadRequest(response.MessageString);

            return Ok();
        }

        [HttpGet("{id}/bookings")]
        public ActionResult<IEnumerable<BookingDto>> Get(Guid id)
        {
            var meeting = _meetingRepository.GetMeeting(id);

            var bookings = meeting.Bookings.Select(_mapper.Map<BookingDto>);

            return Ok(bookings);
        }
    }
}
