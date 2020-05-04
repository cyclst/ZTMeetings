using System;
using System.Collections.Generic;
using System.Text;

namespace ZTMeetings.Domain.Core
{
    public interface IAggregate
    {
        Guid Id { get; }
    }
}
