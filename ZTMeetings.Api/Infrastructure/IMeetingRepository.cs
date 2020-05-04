using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZTMeetings.Api.Dtos;
using ZTMeetings.Domain;

namespace ZTMeetings.Api.Infrastructure
{
    public interface IMeetingRepository
    {
        Meeting GetMeeting(Guid id);

        Task AddMeetingAsync(Meeting meeting);

        Task SaveMeetingAsync(Meeting meeting);

    }
}
