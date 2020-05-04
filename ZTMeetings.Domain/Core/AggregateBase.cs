using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ZTMeetings.Domain.Core
{
    public class AggregateBase : IAggregate
    {
        public Guid Id { get; protected set; }


        public void ApplyEvent(IAggregateEvent ev)
        {
            ((dynamic)this).Apply((dynamic)ev);
        }

        protected void PublishEvent<TEvent>(TEvent ev)
            where TEvent : IAggregateEvent
        {
            ApplyEvent(ev);
        }
    }
}
