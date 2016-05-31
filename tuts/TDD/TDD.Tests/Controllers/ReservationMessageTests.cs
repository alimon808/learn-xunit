﻿using System;
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
        [Fact]
        public void ShouldHavePickupDate()
        {
            DateTime pickupDate = new DateTime(2010, 1, 1);
            var sut = new ReservationMessage(pickupDate);

            Assert.Equal(pickupDate, sut.PickupDate);

        }
    }
}
