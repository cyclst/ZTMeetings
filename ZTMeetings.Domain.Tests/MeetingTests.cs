using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ZTMeetings.Domain.Tests
{
    [TestFixture]
    public class MeetingTests
    {
        private Meeting _meeting;

        private void AddExisintBookings(int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                _meeting.AddBooking($"Test Employee {i}", $"test{i}@zupa.co.uk");
            }
        }

        [Test]
        [TestCase(0, "New Person", "newbie@zupa.co.uk", "A1")]
        [TestCase(3, "New Person", "newbie@zupa.co.uk", "A4")]
        [TestCase(10, "New Person", "newbie@zupa.co.uk", "B1")]
        [TestCase(90, "New Person", "newbie@zupa.co.uk", "J1")]
        public void AddBooking_GivenExistingBookings_ThenBookingShouldBeAdded(int existingBookings, string name, string email, string seat)
        {
            //A
            _meeting = new Meeting(Guid.NewGuid(), DateTime.Now);

            AddExisintBookings(existingBookings);

            //A
            var result = _meeting.AddBooking(name, email);

            //A
            var booking = _meeting.Bookings.Single(b => b.EmployeeEmail == email);


            Assert.IsTrue(result.IsSuccessful);
            Assert.AreEqual(seat, booking.SeatNumber);
        }

        [Test]
        public void AddBooking_GivenFullMeeting_ThenErrorShouldBeReturned()
        {
            //A
            _meeting = new Meeting(Guid.NewGuid(), DateTime.Now);

            AddExisintBookings(100);

            //A
            var result = _meeting.AddBooking("New Person", "newbie@zupa.co.uk");

            //A

            Assert.IsFalse(result.IsSuccessful);
        }

        [Test]
        public void AddBooking_GivenDuplicatedEmployee_ThenErrorShouldBeReturned()
        {
            //A
            _meeting = new Meeting(Guid.NewGuid(), DateTime.Now);

            _meeting.AddBooking("New Person", "newbie@zupa.co.uk");

            //A
            var result = _meeting.AddBooking("New Person", "newbie@zupa.co.uk");

            //A

            Assert.IsFalse(result.IsSuccessful);
        }

        [Test]
        public void AddBooking_WhenEmptyName_ThenErrorShouldBeReturned()
        {
            //A
            _meeting = new Meeting(Guid.NewGuid(), DateTime.Now);

            //A
            var result = _meeting.AddBooking("", "newbie@zupa.co.uk");

            //A

            Assert.IsFalse(result.IsSuccessful);
        }

        [Test]
        public void AddBooking_WhenEmptyEmail_ThenErrorShouldBeReturned()
        {
            //A
            _meeting = new Meeting(Guid.NewGuid(), DateTime.Now);

            //A
            var result = _meeting.AddBooking("New Person", "");

            //A

            Assert.IsFalse(result.IsSuccessful);
        }

        [Test]
        public void AddBooking_WhenInvalidEmail_ThenErrorShouldBeReturned()
        {
            //A
            _meeting = new Meeting(Guid.NewGuid(), DateTime.Now);

            //A
            var result = _meeting.AddBooking("New Person", "New Person");

            //A

            Assert.IsFalse(result.IsSuccessful);
        }
    }
}
