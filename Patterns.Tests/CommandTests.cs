﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.Command;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        [TestCategory("Command")]
        public void BikeRider_Ride_ChangesBikeState()
        {
            // Arrange
            BikeRider rider = new BikeRider();

            // Act
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.TurnLeft);
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.TurnRight);
            rider.Ride(BikeAction.GoForwards);
            rider.Ride(BikeAction.GoBackwards);

            rider.UnRide(3);

            // Assert
            Assert.AreEqual<string>(rider.ToString(), " - Bikes current postion is (-1, 3) and 3.16227766016838 from origin");
        }
    }
}
