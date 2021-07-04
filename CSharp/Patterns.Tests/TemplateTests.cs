using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.Template;

namespace Patterns.Tests
{
    [TestClass]
    public class TemplateTests
    {
        [TestMethod]
        [TestCategory("Template")]
        public void MountainBikeTemplate_AllValidInput_ReturnsInstanceOfMountainBikeShop()
        {
            // Arrange
            BaseBikeShop shop = new MountainBikeShop();

            // Act
            shop.BuildBike();

            // Assert
            Assert.IsInstanceOfType(shop, typeof(MountainBikeShop));
        }

        [TestMethod]
        [TestCategory("Template")]
        public void RoadBikeTemplate_AllValidInput_ReturnsInstanceOfRoadBikeShop()
        {
            // Arrange
            BaseBikeShop shop = new RoadBikeShop();

            // Act
            shop.BuildBike();

            // Assert
            Assert.IsInstanceOfType(shop, typeof(RoadBikeShop));
        }
    }
}
