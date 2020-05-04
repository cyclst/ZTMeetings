using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ZTMeetings.Api.CommandHandlers;
using ZTMeetings.Api.Dtos;

namespace ZTMeetings.Api.Commands
{
    public class AddMeetingCommand : ICommand
    {
        public Guid MeetingId { get; set; }

        public DateTime MeetingDateTime { get; set; }

        public AddMeetingCommand(Guid meetingId, DateTime meetingDateTime)
        {
            MeetingId = meetingId;
            MeetingDateTime = meetingDateTime;
        }
    }
}
