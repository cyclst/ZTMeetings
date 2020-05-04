using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ZTMeetings.Api.Dtos;
using ZTMeetings.Domain;

namespace ZTMeetings.Api.Config
{
    public class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<Booking, BookingDto>();
        }
    }
}
