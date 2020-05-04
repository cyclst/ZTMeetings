using System;
using System.Collections.Generic;
using System.Linq;
using ZTMeetings.Domain.Core;
using ZTMeetings.Domain.Events;

namespace ZTMeetings.Domain
{
    public class Meeting : AggregateBase
    {
        public ICollection<Booking> Bookings { get; private set; }

        public DateTime MeetingDateTime { get; private set; }

        public Meeting(Guid id, DateTime meetingDateTime)
        {
            PublishEvent(new MeetingCreatedEvent(id, meetingDateTime));
        }

        public AggregateResponse AddBooking(string employeeName, string employeeEmail)
        {
            if(string.IsNullOrWhiteSpace(employeeName))
                return AggregateResponse.Error("Employee Name must be supplied");

            if (string.IsNullOrWhiteSpace(employeeEmail))
                return AggregateResponse.Error("Employee Email must be supplied");

            if (!employeeEmail.Contains('@')) // Just a rough example!
                return AggregateResponse.Error("Employee Email is invalid");

            if (Bookings.Count == 100) //TODO - Make configurable
                return AggregateResponse.Error($"Meeting is full. Could not book: {employeeName}");

            if (Bookings.Any(b => b.EmployeeName.Equals(employeeName, StringComparison.InvariantCultureIgnoreCase)
                                  || b.EmployeeEmail.Equals(employeeEmail,
                                      StringComparison.InvariantCultureIgnoreCase)))
            {
                return AggregateResponse.Error($"The following employee already has a seat booked: {employeeName}");
            }

            PublishEvent(new BookingCreatedEvent(GetNextAvailableSeat(), employeeName, employeeEmail));

            return AggregateResponse.Ok();
        }

        internal void Apply(MeetingCreatedEvent ev)
        {
            Id = ev.AggregateId;
            MeetingDateTime = ev.MeetingDateTime;
            Bookings = new List<Booking>();
        }

        internal void Apply(BookingCreatedEvent ev)
        {
            Bookings.Add(new Booking
            {
                SeatNumber = ev.SeatNumber,
                EmployeeName = ev.EmployeeName,
                EmployeeEmail = ev.EmployeeEmail
            });
        }

        private string GetNextAvailableSeat()
        {
            var rowLabels = new[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};

            // TODO - This could probably be cleaned up with divisible/remainder logic
            int row = 0;
            int col = 1;

            for (int i = 1; i <= Bookings.Count; i++)
            {
                if (col == 10)
                {
                    row++;
                    col = 0;
                }

                col++;
            }

            return $"{rowLabels[row]}{col}";
        }
    }
}
