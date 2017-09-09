using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Patterns.Behavioral.Iterator;

namespace Patterns.Tests
{
    [TestClass]
    public class IteratorTests
    {
        [TestMethod]
        [TestCategory("Iterator")]
        public void BikeProductionLine_CreateIterator_IteratorsAcrossAllBikesInPRoductionLine()
        {
            // Arrange
            Mock<Bike> mockBike = new Mock<Bike>();
            BikeProductionLine line = new BikeProductionLine(mockBike.Object);
            BikeIterator iterator = line.CreateIterator();

            // Act
            while(!iterator.IsFinished)
            {
                iterator.CurrentBike.Build();
                iterator.Next();
            }

            // Assert
            mockBike.Verify(m => m.Build(), Times.Once);
        }
    }
}
