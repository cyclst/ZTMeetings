using System;
using System.Collections.Generic;
using System.Text;

namespace ZTMeetings.Domain.Core
{
    // Better than returning exceptions!
    public class AggregateResponse
    {
        public string Message { get; private set; }
        public bool IsSuccessful { get; private set; }

        public static AggregateResponse Error(string message)
        {
            return new AggregateResponse
            {
                IsSuccessful = false,
                Message = message
            };
        }

        public static AggregateResponse Ok()
        {
            return new AggregateResponse
            {
                IsSuccessful = true
            };
        }
    }
}
