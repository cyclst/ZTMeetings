using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ZTMeetings.Api.Commands;
using ZTMeetings.Domain;

namespace ZTMeetings.Api.CommandHandlers
{
    public class MeetingCommandHandler : 
        IRequestHandler<AddMeetingCommand, CommandHandlerResponse>,
        IRequestHandler<RequestBookingCommand, CommandHandlerResponse>
    {
        public async Task<CommandHandlerResponse> Handle(AddMeetingCommand command, CancellationToken cancellationToken)
        {
            var response = new CommandHandlerResponse();

            var meeting = new Meeting(command.MeetingId, command.MeetingDateTime);

            // Add DB save

            return response;
        }

        public async Task<CommandHandlerResponse> Handle(RequestBookingCommand command, CancellationToken cancellationToken)
        {
            var response = new CommandHandlerResponse();
            
            // This validation could be moved into the aggregate if needed
            if (command.Employees.Count > 4)
                return response.Error("The maximum number of seats that can be booked by an employee is 4");

            var meeting = new Meeting(command.MeetingId, DateTime.Now); //Replace with DB load

            foreach (var employee in command.Employees)
            {
                var result = meeting.AddBooking(employee.EmployeeName, employee.EmployeeEmail);

                if(!result.IsSuccessful)
                    response.AddError(result.Message);
            }

            return response;
        }
    }
}
