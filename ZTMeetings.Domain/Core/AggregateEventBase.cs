using System;
using System.Collections.Generic;
using System.Text;

namespace ZTMeetings.Domain.Core
{
    public class AggregateEventBase
    {
        public Guid EventId { get; } = Guid.NewGuid();
        public Guid AggregateId { get; protected set; }
    }
}
