using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ZTMeetings.Api.CommandHandlers;

namespace ZTMeetings.Api.Commands
{
    public interface ICommand :  IRequest<CommandHandlerResponse>
    {
    }
}
