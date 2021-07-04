using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.Visitor;
using System;

namespace Patterns.Tests
{
    [TestClass]
    public class VisitorTests
    {
        [TestMethod]
        [TestCategory("Visitor")]
        public void TirePumpRobot_DoWork_ChangesTirePressure()
        {
            // Arrange
            BikeShop shop = new BikeShop();
            IBike testBike = new MountainBike("Test");
            int originalTirePressure = testBike.TirePressure;
            shop.Attach(testBike);

            // Act
            shop.AcceptVisitor(new TirePumpRobot());

            // Assert
            Assert.IsFalse(testBike.TirePressure == originalTirePressure);
        }

        [TestMethod]
        [TestCategory("Visitor")]
        public void PaintRobot_DoWork_ChangesBikeColour()
        {
            // Arrange
            BikeShop shop = new BikeShop();
            IBike testBike = new MountainBike("Test");
            ConsoleColor originalColour = testBike.Colour;
            shop.Attach(testBike);

            // Act
            shop.AcceptVisitor(new PainterRobot());

            // Assert - This could fail if it randomly chooses the original colour again
            Assert.IsFalse(testBike.Colour == originalColour);
        }
    }
}
