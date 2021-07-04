using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Behavioral.ChainOfResponsibility;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class ChainOfResponsibilityTests
    {
        [TestMethod]
        [TestCategory("Stratergy")]
        public void BikeShop_FillOrder_PassesRequestAlongChain()
        {
            // Arrange
            BikeShop mountainBikes = new MountainBikeShop("Tom's Mountain Bikes");
            BikeShop roadBikes = new RoadBikeShop("Dick's road bikes");
            Mock<BikeShop> mockShop = new Mock<BikeShop>("Mock Shop");
            
            mountainBikes.Successor = roadBikes;
            roadBikes.Successor = mockShop.Object;

            // Act
            mountainBikes.FillOrder(Common.BikeType.Hybrid);

            // Assert
            mockShop.Verify(m => m.FillOrder(It.IsAny<Common.BikeType>()), Times.Once);
        }
    }
}
