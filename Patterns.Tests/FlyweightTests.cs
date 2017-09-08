using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Flyweight;
using Patterns.Common;
using Moq;

namespace Patterns.Tests
{
    [TestClass]
    public class FlyweightTests
    {
        [TestMethod]
        [TestCategory("Flyweight")]
        public void BikeRace_Ride_CallsRideOnCompetitor()
        {
            // Arrange
            Mock<IBikeRace> mockRace = new Mock<IBikeRace>();
            Mock<Competitor> mockCompetitor = new Mock<Competitor>();

            mockRace.Setup(x => x.GetCompetitor(It.IsAny<BikeType>())).Returns(mockCompetitor.Object);

            Competitor competitor = mockRace.Object.GetCompetitor(BikeType.Hybrid);

            // Act
            competitor.Ride();

            // Assert
            mockCompetitor.Verify(m => m.Ride(), Times.Once);
        }
    }
}
