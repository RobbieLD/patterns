using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Structural.Marker;
using System.Collections.Generic;

namespace Patterns.Tests
{
    [TestClass]
    public class MarkerTests
    {
        [TestMethod]
        [TestCategory("Marker")]
        public void InterfaceMarshal_StartRace_UpdatesCorrectBikes()
        {
            // Arrange
            var riders = new List<Bike>
            {
                new Cannondale(),
                new Trek()
            };

            var marshal = new InterfaceRaceMarshal(riders);

            // Act
            marshal.StartRace();

            // Assert
            Assert.IsTrue(riders[0].IsRacing);
            Assert.IsFalse(riders[1].IsRacing);
        }

        [TestMethod]
        [TestCategory("Marker")]
        public void AttributeMArshal_StartRace_UpdatesCorrectBikes()
        {
            // Arrange
            var riders = new List<Bike>
            {
                new Cannondale(),
                new Trek()
            };

            var marshal = new AttributeRaceMarshal(riders);

            // Act
            marshal.StartRace();

            // Assert
            Assert.IsTrue(riders[1].IsRacing);
            Assert.IsFalse(riders[0].IsRacing);
        }
    }
}
