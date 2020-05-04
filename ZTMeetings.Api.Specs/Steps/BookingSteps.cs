using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ZTMeetings.Api.Specs.Models;

namespace ZTMeetings.Api.Specs.Steps
{
    [Binding]
    public class BookingSteps
    {
        [Given(@"there are no booked seats")]
        public void GivenThereAreNoBookedSeats()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Seats have been booked for Employees")]
        [When(@"I book a seat for Employees")]
        public void WhenIBookASeatForEmployees(Table table)
        {
            var employees = table.CreateSet<Employee>();

            ScenarioContext.Current.Pending();
        }

        [Then(@"the booked seats should be")]
        public void ThenTheBookedSeatsShouldBe(Table table)
        {
            var bookings = table.CreateSet<Booking>();

            ScenarioContext.Current.Pending();
        }

        [Given(@"(.*) Seats Have Been Booked By Employees")]
        public void GivenSeatsHaveBeenBookedByEmployees(int amount)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the following error should be returned '(.*)'")]
        public void ThenTheFollowingErrorShouldBeReturned(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
    }
}
