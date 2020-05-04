using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ZTMeetings.Api.Specs.Models;

namespace ZTMeetings.Api.Specs.Steps
{
    [Binding]
    public class BookingSteps
    {
        private static string _lastErrorMessage;

        [Given(@"there are no booked seats")]
        public void GivenThereAreNoBookedSeats()
        {
            
        }

        [Given(@"Seats have been booked for Employees")]
        [When(@"I book a seat for Employees")]
        public async Task WhenIBookASeatForEmployees(Table table)
        {
            try
            {

                var employees = table.CreateSet<Employee>();

                await MeetingsApiClient.New().BookSeatsAsync(employees);
            }
            catch (Exception ex)
            {
                _lastErrorMessage = ex.Message;
            }
        }

        [Then(@"the booked seats should be")]
        public async Task ThenTheBookedSeatsShouldBe(Table table)
        {
            var actualBookings = await MeetingsApiClient.New().GetBookingsAsync();

            table.CompareToSet(actualBookings);
        }

        [Given(@"(.*) Seats Have Been Booked By Employees")]
        public async Task GivenSeatsHaveBeenBookedByEmployees(int amount)
        {
            var employees = new List<Employee>();

            for (int i = 1; i <= amount; i++)
            {
                employees.Add(new Employee
                {
                    EmployeeName = $"Test Employee {i}",
                    EmployeeEmail = $"test{i}@zupa.co.uk"
                });
            }

            await MeetingsApiClient.New().BookSeatsAsync(employees);
        }

        [Then(@"the following error should be returned '(.*)'")]
        public void ThenTheFollowingErrorShouldBeReturned(string error)
        {
            Assert.AreEqual(error, _lastErrorMessage);
        }
        
    }
}
