using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Creational.Prototype;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class PrototypeTests
    {
        [TestMethod]
        [TestCategory("Prototype")]
        public void BikeProductionLine_Run_BuildsCorrectNumberOfBikes()
        {
            // Arrange
            int numberOfBikesToMake = 100;

            Mock<Bike> mockBike = new Mock<Bike>();
            BikeProductionLine line = new BikeProductionLine(mockBike.Object, numberOfBikesToMake);

            mockBike.Setup(m => m.Clone()).Returns(mockBike.Object);

            // Act
            line.Run();

            // Assert
            mockBike.Verify(m => m.Clone(), Times.Exactly(numberOfBikesToMake));
        }
    }
}
