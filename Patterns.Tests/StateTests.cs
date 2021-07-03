using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.State;
using System;

namespace Patterns.Tests
{
    [TestClass]
    public class StateTests
    {

        [TestMethod]
        [TestCategory("State")]
        public void Bike_AddComponent_ChangesState()
        {
            // Arrange
            Bike bike = new Bike("Rob");

            // Act

            // Attemp to negotiate a pothole on a road bike
            Assert.ThrowsException<NotSupportedException>(() => bike.AttemptToNegotiatePothole());

            bike.Add(ComponentType.Shocks);

            // Now that we've got shocks we're a hybrid bike so we can negotiate a pothole ok.

            // Assert
            Assert.IsTrue(bike.AttemptToNegotiatePothole());
        }
    }
}
