using System;
using System.Collections.Generic;
using System.Text;

namespace ZTMeetings.Domain.Core
{
    public interface IAggregateEvent
    {
        Guid EventId { get; }
        Guid AggregateId { get; }
    }
}
