using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZTMeetings.Api.Dtos
{
    public class MeetingDto
    {
        public Guid Id { get; set; }

        public DateTime DateTime { get; set; }
    }
}
