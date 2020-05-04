using System;
using System.Collections.Generic;
using System.Text;
using ZTMeetings.Domain.Core;

namespace ZTMeetings.Domain.Events
{
    public class MeetingCreatedEvent : AggregateEventBase, IAggregateEvent
    {
        public DateTime MeetingDateTime { get; }

        public MeetingCreatedEvent(Guid id, DateTime meetingDateTime)
        {
            AggregateId = id;
            MeetingDateTime = meetingDateTime;
        }
    }
}
