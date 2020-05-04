using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZTMeetings.Domain.Core;

namespace ZTMeetings.Api.CommandHandlers
{
    public class CommandHandlerResponse
    {
        private readonly List<string> _messages = new List<string>();
        public IEnumerable<string> Messages => _messages;
        public bool IsSuccessful { get; private set; } = true;

        public void AddError(string message)
        {
            _messages.Add(message);
            IsSuccessful = false;
        }

        public CommandHandlerResponse Error(string message)
        {
            this.AddError(message);

            return this;
        }

        public string MessageString => _messages.Count == 0 ? "" : string.Join(';', _messages);
    }
}
