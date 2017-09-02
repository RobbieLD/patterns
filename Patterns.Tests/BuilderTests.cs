using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Builder;
using Moq;
namespace Patterns.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        [TestCategory("Builder")]
        public void BikeShop_Build_BuildsBikes()
        {
            // Arrange
            BikeShop shop = new BikeShop();
            Mock<BikeBuilder> mockBuilder = new Mock<BikeBuilder>();

            // Act
            shop.Build(mockBuilder.Object);

            // Assert
            mockBuilder.Verify(m => m.AddBrakes(), Times.Once);
            mockBuilder.Verify(m => m.AddFrame(), Times.Once);
            mockBuilder.Verify(m => m.AddWheels(), Times.Once);
        }
    }
}
