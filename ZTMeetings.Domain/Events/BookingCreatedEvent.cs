using System;
using System.Collections.Generic;
using System.Text;
using ZTMeetings.Domain.Core;

namespace ZTMeetings.Domain.Events
{
    public class BookingCreatedEvent : AggregateEventBase, IAggregateEvent
    {
        public string SeatNumber { get; }

        public string EmployeeName { get; }

        public string EmployeeEmail { get; }

        public BookingCreatedEvent(string seatNumber, string employeeName, string employeeEmail)
        {
            SeatNumber = seatNumber;
            EmployeeName = employeeName;
            EmployeeEmail = employeeEmail;
        }
    }
}
