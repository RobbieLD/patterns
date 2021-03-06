﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Structural.Bridge;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class BridgeTests
    {

        [TestMethod]
        [TestCategory("Bridge")]
        public void Rider_Ride_CallCorrectBridgeInstanceRideMethod()
        {
            // Arrange
            AbstractRider rider = new Rider("Rob");

            Mock<IBike> mockBike = new Mock<IBike>();

            rider.Bike = mockBike.Object;

            // Act
            rider.RideBike();

            // Assert
            mockBike.Verify(m => m.Ride(), Times.Once);

        }
    }
}
