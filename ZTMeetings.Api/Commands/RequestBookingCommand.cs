using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ZTMeetings.Api.CommandHandlers;
using ZTMeetings.Api.Dtos;

namespace ZTMeetings.Api.Commands
{
    public class RequestBookingCommand : ICommand
    {
        public Guid MeetingId { get; }
        public IReadOnlyCollection<EmployeeDto> Employees { get; }

        public RequestBookingCommand(Guid meetingId, IReadOnlyCollection<EmployeeDto> employees)
        {
            MeetingId = meetingId;
            Employees = employees;
        }
    }
}
