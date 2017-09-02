using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Decorator;

namespace Patterns.Decorator.Tests
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        [TestCategory("Decorator")]
        public void ShocksDecorator_AllValidInput_ReturnsInstanceOfBike()
        {
            // Arrange
            MountainBike bike = new MountainBike("Red", 26, 90, 1);

            // Act
            Shocks bikeWithShocks = new Shocks(bike);
            bikeWithShocks.AddShocks(6);
            bikeWithShocks.Display();

            // Assert
            Assert.IsInstanceOfType(bikeWithShocks, typeof(Bike));
        }

        [TestMethod]
        [TestCategory("Decorator")]
        public void BrakesDecorator_AllValidInput_ReturnsInstanceOfBike()
        {
            // Arrange
            MountainBike bike = new MountainBike("Red", 26, 90, 1);

            // Act
            Brakes bikeWithBrakes = new Brakes(bike);
            bikeWithBrakes.AddBrakes(BrakeType.Disc);
            bikeWithBrakes.Display();

            // Assert
            Assert.IsInstanceOfType(bikeWithBrakes, typeof(Bike));
        }

        [TestMethod]
        [TestCategory("Decorator")]
        public void AllDecorators_AllValidInput_ReturnsInstanceOfBike()
        {
            // Arrange
            MountainBike bike = new MountainBike("Red", 26, 90, 1);

            // Act
            Brakes bikeWithBrakes = new Brakes(bike);
            bikeWithBrakes.AddBrakes(BrakeType.Disc);
            bikeWithBrakes.Display();

            Shocks bikeWithBrakesAndShocks = new Shocks(bikeWithBrakes);
            bikeWithBrakesAndShocks.AddShocks(6);
            bikeWithBrakesAndShocks.Display();

            // Assert
            Assert.IsInstanceOfType(bikeWithBrakes, typeof(Bike));
            Assert.IsInstanceOfType(bikeWithBrakesAndShocks, typeof(Bike));
        }
    }
}
