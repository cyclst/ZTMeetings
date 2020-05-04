using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ZTMeetings.Api.Commands;
using ZTMeetings.Api.Infrastructure;
using ZTMeetings.Domain;

namespace ZTMeetings.Api.CommandHandlers
{
    public class MeetingCommandHandler : 
        IRequestHandler<AddMeetingCommand, CommandHandlerResponse>,
        IRequestHandler<RequestBookingCommand, CommandHandlerResponse>
    {
        private readonly IMeetingRepository _meetingRepository;

        public MeetingCommandHandler(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository ?? throw new ArgumentNullException(nameof(meetingRepository));
        }

        public async Task<CommandHandlerResponse> Handle(AddMeetingCommand command, CancellationToken cancellationToken)
        {
            var response = new CommandHandlerResponse();

            try
            {
                var meeting = new Meeting(command.MeetingId, command.MeetingDateTime);

                await _meetingRepository.AddMeetingAsync(meeting);
            }
            catch (Exception ex)
            {
                response.AddError(ex.Message);
            }

            return response;
        }

        public async Task<CommandHandlerResponse> Handle(RequestBookingCommand command, CancellationToken cancellationToken)
        {
            var response = new CommandHandlerResponse();

            try
            {
                // This validation could be moved into the aggregate if needed
                if (command.Employees.Count > 4)
                    return response.Error("The maximum number of seats that can be booked by an employee is 4");

                var meeting = _meetingRepository.GetMeeting(command.MeetingId);

                foreach (var employee in command.Employees)
                {
                    var result = meeting.AddBooking(employee.EmployeeName, employee.EmployeeEmail);

                    if(!result.IsSuccessful)
                        response.AddError(result.Message);
                }

                await _meetingRepository.SaveMeetingAsync(meeting);
            }
            catch (Exception ex)
            {
                response.AddError(ex.Message);
            }

            return response;
        }
    }
}
