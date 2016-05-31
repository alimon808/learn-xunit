using System;
using TDD.Controllers;
using Xunit;

// When creating a message for the reservation system
// - must include a pickup date
// - pickup date must be in the future
// - must include a dropoff date
// - dropoff must be later than the pickup date
// - may include the registered customer's club number
namespace TDD.Tests.Controllers
{
    
    public class ReservationMessageTests
    {
        public ReservationMessageTests()
        {
            SystemTime.Now = () => new DateTime(2009, 1, 1);
        }

        [Fact]
        public void ShouldHavePickupDate()
        {
            DateTime pickupDate = new DateTime(2009, 12, 31);
            var sut = new ReservationMessage(pickupDate);

            Assert.Equal(pickupDate, sut.PickupDate);

        }

        [Fact]
        public void ShouldFailWhenPickupDateIsInThePast()
        {
            DateTime pickupDate = new DateTime(2001, 1, 1);

            ArgumentException ex = Assert.Throws<ArgumentException>(() => new ReservationMessage(pickupDate));

            Assert.Equal("pickupDate", ex.ParamName);
        }
    }
}
