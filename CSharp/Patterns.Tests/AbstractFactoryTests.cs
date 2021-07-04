using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Creational.AbstractFactory;

namespace Patterns.Tests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        [TestCategory("AbstractFactory")]
        public void MountainBikeShop_OrderBike_ReturnsInstanceOfMountainBike()
        {
            // Arrange
            IBikeShop shop = new MountainBikeShop();

            // Act
            IBike bike = shop.OrderBike("test");

            // Assert
            Assert.IsInstanceOfType(bike, typeof(MountainBike));
        }

        [TestMethod]
        [TestCategory("AbstractFactory")]
        public void RoadBikeShop_OrderBike_ReturnsInstanceOfRoadBike()
        {
            // Arrange
            IBikeShop shop = new RoadBikeShop();

            // Act
            IBike bike = shop.OrderBike("test");

            // Assert
            Assert.IsInstanceOfType(bike, typeof(RoadBike));
        }

        [TestMethod]
        [TestCategory("AbstractFactory")]
        public void MountainBikeShop_OrderBike_ReturnsInstanceOfHybridBike()
        {
            // Arrange
            IBikeShop shop = new HybridBikeShop();

            // Act
            IBike bike = shop.OrderBike("test");

            // Assert
            Assert.IsInstanceOfType(bike, typeof(HybridBike));
        }
    }
}
