using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ZTMeetings.Api.Dtos;

namespace ZTMeetings.Api.Specs.Steps
{
    [Binding]
    public class BookingSteps
    {
        private Guid _meetingId;
        private static string _lastErrorMessage;

        [Given(@"a new meeting")]
        public async Task GivenANewMeeting()
        {
            _meetingId = Guid.NewGuid();

            await MeetingsApiClient.New().CreateMeetingAsync(_meetingId, DateTime.Now);
        }

        [Given(@"Seats have been booked for Employees")]
        [When(@"I book a seat for Employees")]
        public async Task WhenIBookASeatForEmployees(Table table)
        {
            try
            {
                var employees = table.CreateSet<EmployeeDto>();

                await MeetingsApiClient.New().BookSeatsAsync(_meetingId, employees.ToList());
            }
            catch (Exception ex)
            {
                _lastErrorMessage = ex.Message;
            }
        }

        [Then(@"the booked seats should be")]
        public async Task ThenTheBookedSeatsShouldBe(Table table)
        {
            var actualBookings = await MeetingsApiClient.New().GetBookingsAsync(_meetingId);

            table.CompareToSet(actualBookings);
        }

        [Given(@"(.*) Seats Have Been Booked By Employees")]
        public async Task GivenSeatsHaveBeenBookedByEmployees(int amount)
        {
            var employees = new List<EmployeeDto>();

            for (int i = 1; i <= amount; i++)
            {
                employees.Add(new EmployeeDto
                {
                    EmployeeName = $"Test Employee {i}",
                    EmployeeEmail = $"test{i}@zupa.co.uk"
                });

                if (employees.Count % 4 == 0 || i == amount)
                {
                    await MeetingsApiClient.New().BookSeatsAsync(_meetingId, employees);

                    employees = new List<EmployeeDto>();
                }
            }
        }

        [Then(@"the following error should be returned '(.*)'")]
        public void ThenTheFollowingErrorShouldBeReturned(string error)
        {
            Assert.AreEqual(error, _lastErrorMessage);
        }
        
    }
}
